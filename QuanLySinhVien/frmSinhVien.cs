using DocumentFormat.OpenXml.Office2010.Excel;
using QuanLyBanHang.Classes;
using QuanLySinhVien.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace QuanLySinhVien
{
	public partial class frmSinhVien : Form
	{
		ProcessDataBase data = new ProcessDataBase();
		CommonFunctions function = new CommonFunctions();
		string FILEANH;
		public frmSinhVien()
		{
			InitializeComponent();
			AddComboBoxGioiTinh();
			AddComboBoxTinhTrang();
		}


		public void AddComboBoxGioiTinh()
		{
			cbbGioiTinh.Items.Add("Nam");
			cbbGioiTinh.Items.Add("Nữ");
		}
		public void AddComboBoxTinhTrang()
		{
			cbbTinhTrang.Items.Add("Đang học");
			cbbTinhTrang.Items.Add("Học xong");
			cbbTinhTrang.Items.Add("Thôi học");
		}

		void LoadData()
		{
			DataTable dtSV = data.DataReader("select * from SinhVien");
			dgvDanhSach.DataSource = dtSV;
		}
		void ResetValue()
		{
			txtHoTen.Text = "";
			txtMaSinhVien.Text = "";
			dtpNgaySinh.Value = DateTime.Today;
			txtemail.Text = "";
			txtQueQuan.Text = "";
			txtsdt.Text = "";
			FILEANH = "";
			txtMaSinhVien.Focus();
			btnThem.Enabled = true;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			//picAnhDaiDien.Refresh();
		}

		private void frmSinhVien_Load(object sender, EventArgs e)
		{

			string sqlSelect = "select * from SinhVien";
			DataTable dt = data.DataReader(sqlSelect);
			dgvDanhSach.DataSource = dt;
			dgvDanhSach.Columns[0].HeaderText = "Mã sinh viên";
			dgvDanhSach.Columns[1].HeaderText = "Họ tên";
			dgvDanhSach.Columns[2].HeaderText = "Ngày sinh";
			dgvDanhSach.Columns[3].HeaderText = "Giới tính";
			dgvDanhSach.Columns[4].HeaderText = "Tình trạng";
			dgvDanhSach.Columns[5].HeaderText = "Email";
			dgvDanhSach.Columns[6].HeaderText = "Quê quán";
			dgvDanhSach.Columns[7].HeaderText = "Số điện thoại";
			dgvDanhSach.Columns[8].HeaderText = "Mã ngành";
			dgvDanhSach.BackgroundColor = SystemColors.Window;
			ResetValue();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			DataTable dtCheckhang = data.DataReader("Select * from SinhVien  where MaSV='" + txtMaSinhVien.Text + "'");
			if (dtCheckhang.Rows.Count > 0)
			{
				MessageBox.Show("Mã sinh viên đã có, mời nhập lại ");
				txtMaSinhVien.Focus();
				return;
			}
			else
			{

				if (txtHoTen.Text == "")
				{
					MessageBox.Show("Không được để trống họ tên ");
					txtHoTen.Focus();
					return;
				}
				if (txtMaSinhVien.Text == "")
				{
					MessageBox.Show("Không được để trống mã sinh viên ");
					txtMaSinhVien.Focus();
					return;
				}
				if (txtemail.Text.Trim() == "")
				{
					MessageBox.Show("Không được để trống Email ");
					txtemail.Focus();
					return;
				}
				if (txtQueQuan.Text.Trim() == "")
				{
					MessageBox.Show("Không được để trống quê quán ");
					txtQueQuan.Focus();
					return;
				}
				if (txtsdt.Text.Trim() == "")
				{
					MessageBox.Show("Không được để trống số điện thoại ");
					txtsdt.Focus();
					return;
				}
				string sqlInsert = " insert into SinhVien values ('" + txtMaSinhVien.Text + "',N'" + txtHoTen.Text + "','" + dtpNgaySinh.Text + "',N'" + cbbGioiTinh.Text + "',N'" + cbbTinhTrang.Text + "','" + txtemail.Text + "','" + txtQueQuan.Text + "','" + txtsdt.Text + "','" + cbbMaNganh.Text + "','" + FILEANH + "') ";
				data.DataChange(sqlInsert);
				LoadData();
				MessageBox.Show("Thêm thành công ");
				ResetValue();
			}
		}

		private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtHoTen.Text = dgvDanhSach.CurrentRow.Cells[1].Value.ToString();
			txtMaSinhVien.Text = dgvDanhSach.CurrentRow.Cells[0].Value.ToString();
			dtpNgaySinh.Text = dgvDanhSach.CurrentRow.Cells[2].Value.ToString();
			cbbGioiTinh.Text = dgvDanhSach.CurrentRow.Cells[3].Value.ToString();
			cbbTinhTrang.Text = dgvDanhSach.CurrentRow.Cells[4].Value.ToString();
			txtemail.Text = dgvDanhSach.CurrentRow.Cells[5].Value.ToString();
			txtQueQuan.Text = dgvDanhSach.CurrentRow.Cells[6].Value.ToString();
			txtsdt.Text = dgvDanhSach.CurrentRow.Cells[7].Value.ToString();
			cbbMaNganh.Text = dgvDanhSach.CurrentRow.Cells[8].Value.ToString();
			FILEANH = dgvDanhSach.CurrentRow.Cells[9].Value.ToString();
			try
			{
				picAnhDaiDien.Image = Image.FromFile(Application.StartupPath + "\\img-SV\\" + FILEANH);
			}
			catch
			{
				picAnhDaiDien = null;
			}
			btnThem.Enabled = false;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay Không ", MessageBoxButtons.YesNo,
							  MessageBoxIcon.Question) == DialogResult.Yes)
					data.DataChange("DELETE dbo.SinhVien WHERE MaSV = '" + txtMaSinhVien.Text + "'");
				LoadData();
				ResetValue();
			}
			catch
			{
				MessageBox.Show("Không thể xóa sinh viên này");
			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			DataTable dtCheckhang = data.DataReader("Select * from SinhVien  where MaSV='" + txtMaSinhVien.Text + "'");
			if (dtCheckhang.Rows.Count > 0)
			{
				MessageBox.Show("Mã sinh viên đã có, mời nhập lại ");
				txtMaSinhVien.Focus();
				return;
			}
			else
			{
				data.DataChange("update SinhVien set HoTen=N'" + txtHoTen.Text + "',MaSV='"
								+ txtMaSinhVien.Text + "',NgaySinh='" + dtpNgaySinh.Text + "',GioiTinh='"
								+ cbbGioiTinh.Text + "',TinhTrang='" + cbbTinhTrang.Text + "',Email='"
								+ txtemail.Text + "',QueQuan='" + txtQueQuan.Text + "',SoDT='" + txtsdt.Text
								+ "',MaNganh='" + cbbMaNganh.Text + "',AnhSV='" + FILEANH + "' where MaSV='" + txtMaSinhVien.Text + "'");
				LoadData();
				ResetValue();
				MessageBox.Show("Sửa thành công");
			}


		}

		private void btnChonAnh_Click(object sender, EventArgs e)
		{
			string[] image;
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "JPEG images|* .jpg|PNG images|*.png|All files|*.*";
			openFile.FilterIndex = 1;
			openFile.InitialDirectory = Application.StartupPath;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				picAnhDaiDien.Image = Image.FromFile(openFile.FileName);
				image = openFile.FileName.ToString().Split('/');
				FILEANH = image[image.Length - 1];
				MessageBox.Show(FILEANH);
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void cbbMaNganh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbbMaNganh_Click(object sender, EventArgs e)
		{

		}


		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM SinhVien where MaSV is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and MaSV like '%" + txtTK.Text + "%'";
			}
			DataTable dt = data.DataReader(sql);
			if (dt.Rows.Count > 0)
			{
				dgvDanhSach.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có sinh viên");
			}

		}

		private void txtTK_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnRS_Click(object sender, EventArgs e)
		{
			ResetValue();
			LoadData();
		}

		private void btnThem_Paint(object sender, PaintEventArgs e)
		{

		}

		private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
			{
				MessageBox.Show("Bạn chỉ được nhập số nguyên");
				e.Handled = true;
			}
		}
	}
}
