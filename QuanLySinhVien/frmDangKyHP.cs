using DocumentFormat.OpenXml.Drawing.Charts;
using QuanLyBanHang.Classes;
using QuanLySinhVien.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace QuanLySinhVien
{
	public partial class frmDangKyHP : Form
	{
		ProcessDataBase data = new ProcessDataBase();
		CommonFunctions function = new CommonFunctions();
		
		public frmDangKyHP()
		{
			InitializeComponent();
		}

		void LoadData()
		{
			DataTable dtSV = data.DataReader("SELECT SinhVien.MaSV, HoTen, TinhTrang ,Email, SoDT, Hoc.MaLop, TenLop FROM dbo.SinhVien " +
				" INNER JOIN dbo.Hoc ON Hoc.MaSV = SinhVien.MaSV INNER JOIN dbo.LopHocPhan ON LopHocPhan.MaLop = Hoc.MaLop" +
				" INNER JOIN dbo.HocPhan ON HocPhan.MaHP = LopHocPhan.MaHP WHERE TenLop = N'" + cbbLopHP.SelectedValue + "'");
			dgvLopHocPhan.DataSource = dtSV;
			
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string sql = "SELECT MaSV, HoTen FROM SinhVien where MaSV is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and MaSV like '%" + txtTK.Text + "%'";
			}
			DataTable dt = data.DataReader(sql);
			if (dt.Rows.Count > 0)
			{
				dgvSinhVien.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có sinh viên");
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Lấy dòng đang được chọn trong DataGridView2
			DataGridViewRow selectedRow = dgvSinhVien.CurrentRow;
			int count1 =0, count2 = 0;
			if (selectedRow != null)
			{
				// Lấy giá trị từ các ô trong dòng đang được chọn
				string MaSV = selectedRow.Cells["MaSV"].Value.ToString();
				string HoTen = selectedRow.Cells["HoTen"].Value.ToString();
				//MaLop = dgvLopHocPhan.CurrentRow.Cells[5].Value.ToString();

				//So sánh với tất cả sinh viên có trong học phần này
				DataTable dt = data.DataReader("SELECT SinhVien.MaSV, Hoc.MaLop FROM dbo.SinhVien INNER JOIN dbo.Hoc ON Hoc.MaSV = SinhVien.MaSV " +
					"INNER JOIN dbo.LopHocPhan ON LopHocPhan.MaLop = Hoc.MaLop INNER JOIN dbo.HocPhan ON HocPhan.MaHP = LopHocPhan.MaHP " +
					"WHERE TenHP = N'"+cbbTenHP.SelectedValue+"'");

				//Lấy mã lớp
				DataTable dttb = data.DataReader("SELECT MaLop FROM dbo.LopHocPhan WHERE TenLop = '" + cbbLopHP.SelectedValue + "'");
				string MaLop = dttb.Rows[0]["MaLop"].ToString();

				foreach (DataRow row in dt.Rows)
				{
					// Lấy giá trị từ cột "row" của từng dòng
					string maSV = row["MaSV"].ToString();
					// So sánh giá trị với giá trị tìm kiếm
					if (maSV.Equals(MaSV, StringComparison.OrdinalIgnoreCase))
					{
						count1++;
					}
				}

				//So sánh trong lớp học phần
				foreach (DataGridViewRow row in dgvLopHocPhan.Rows)
				{
					string ma = row.Cells["MaSV"].Value?.ToString(); // Kiểm tra null để tránh NullReferenceException
					if (ma != null && ma.Equals(MaSV, StringComparison.OrdinalIgnoreCase))
					{
						count2++;
					}
				}


				if (count1 > 0 || count2 > 0)
				{
					MessageBox.Show("Sinh viên " + HoTen + " đã đăng kí môn này");
				}
				else
				{
					// Thực hiện thêm dữ liKệu vào cơ sở dữ liệu
					data.DataChange("INSERT INTO dbo.Hoc VALUES (N'"+MaSV.Trim()+"',  N'"+MaLop.Trim()+"', NULL, NULL, NULL, NULL)");
					MessageBox.Show("Thêm thành công");
				}

			}

			LoadData();
		}

		private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Khi click vào một ô trong DataGridView, chọn dòng đó
			if (e.RowIndex >= 0)
			{
				dgvSinhVien.Rows[e.RowIndex].Selected = true;
			}
		}


		private void cbbLopHP_Click(object sender, EventArgs e)
		{
			try
			{
				cbbLopHP.DataSource = null;
				function.FillComboBox(cbbLopHP, data.DataReader("SELECT TenLop FROM dbo.LopHocPhan " +
					" INNER JOIN dbo.HocKi ON HocKi.MaHK = LopHocPhan.MaHK WHERE LopHocPhan.MaHP = " +
					" (SELECT MaHP FROM dbo.HocPhan WHERE TenHP = N'" + cbbTenHP.SelectedValue + "')"), "TenLop", "TenLop");
			}
			catch
			{
				MessageBox.Show("Vui lòng chọn tên học phần");
			}

		}

		private void cbbLopHP_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadData();
			//txtMaLop.Text = dgvLopHocPhan.CurrentRow.Cells[5].Value.ToString();
		}

		private void cbbTenHP_Click(object sender, EventArgs e)
		{
			cbbTenHP.DataSource = null;
			function.FillComboBox(cbbTenHP, data.DataReader("Select TenHP from HocPhan"), "TenHP", "TenHP");
		}

		private void dgvLopHocPhan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra xem người dùng đã nhấp đúp vào dòng nào hay chưa
			if (e.RowIndex >= 0)
			{
				// Hiển thị hộp thoại xác nhận xóa
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					string MaSV = dgvLopHocPhan.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
					string MaLop = dgvLopHocPhan.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
					try
					{
						data.DataChange("delete Hoc where MaSV = '" + MaSV + "' and MaLop = '"+MaLop+"'");
						LoadData();
					}
					catch
					{
						MessageBox.Show("Lỗi khi xóa dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void cbbTenHP_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
