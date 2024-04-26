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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLySinhVien
{
	public partial class frmLopHocPhan : Form
	{
		ProcessDataBase data = new ProcessDataBase();
		CommonFunctions function = new CommonFunctions();
		public frmLopHocPhan()
		{
			InitializeComponent();
			DataTable dtHP = data.DataReader("Select * from HocPhan ");
			function.FillComboBox(cbbMHP, dtHP, "MaHP", "MaHP");
			DataTable dtGV = data.DataReader("Select * from GiangVien ");
			function.FillComboBox(cbbMaGV, dtGV, "MaGV", "MaGV");
			DataTable dtHK = data.DataReader("Select * from HocKi ");
			function.FillComboBox(cbbMaHK, dtHK, "MaHK", "MaHK");
		}
		void LoadData()
		{
			DataTable dtHang = data.DataReader("select * from LopHocPhan");
			dgvData.DataSource = dtHang;
		}
		void ResetValue()
		{
			txtMa.Text = "";
			txtTen.Text = "";
			txtSS.Text = "";
			txtTiLe.Text = "";
			txtDD.Text = "";
			cbbMHP.Text = "";
			cbbMaGV.Text = "";
			cbbMaHK.Text = "";
			txtMa.Focus();
			btnThem.Enabled = true;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			string sqlSelect = "select * from LopHocPhan";
			DataTable dt = data.DataReader(sqlSelect);
			dgvData.DataSource = dt;
			dgvData.Columns[0].HeaderText = "Mã Lớp ";
			dgvData.Columns[1].HeaderText = "Tên Lớp ";
			dgvData.Columns[2].HeaderText = "Sí sỗ";
			dgvData.Columns[3].HeaderText = "Tỉ Lệ Điểm";
			dgvData.Columns[4].HeaderText = "Địa Điểm ";
			dgvData.Columns[5].HeaderText = "Mã Học Phần ";
			dgvData.Columns[6].HeaderText = "Mã Giáo Viên ";
			dgvData.Columns[7].HeaderText = "Mã Học Kì ";
			dgvData.BackgroundColor = SystemColors.Window;
			ResetValue();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			DataTable dtCheckhang = data.DataReader("Select * from LopHocPhan  where MaLop='" + txtMa.Text + "'");
			if (txtMa.Text == "")
			{
				MessageBox.Show("Cần nhập mã Lớp  ");
				txtMa.Focus();
				return;
			}
			else
			{
				if (dtCheckhang.Rows.Count > 0)
				{
					MessageBox.Show("Mã Lớp đã có, mời lại ");
					ResetValue();
					txtMa.Focus();
					return;
				}

				if (txtTen.Text == "")
				{
					MessageBox.Show("Không được để trống Tên Lớp ");
					txtTen.Focus();
					return;
				}

				if (txtSS.Text == "")
				{
					MessageBox.Show("Không được để trống Sĩ Số ");
					txtMa.Focus();
					return;
				}

				if (txtDD.Text == "")
				{
					MessageBox.Show("Không được để trống Địa Điểm ");
					txtMa.Focus();
					return;
				}

				if (txtTiLe.Text == "")
				{
					MessageBox.Show("Không được để trống Tỉ lệ điểm  ");
					txtMa.Focus();
					return;
				}

				if (cbbMHP.Text == "")
				{
					MessageBox.Show("Không được để trống Mã học phần ");
					txtMa.Focus();
					return;
				}

				if (cbbMaGV.Text == "")
				{
					MessageBox.Show("Không được để trống Mã Giảng Viên ");
					txtMa.Focus();
					return;
				}

				if (cbbMaHK.Text == "")
				{
					MessageBox.Show("Không được để trống Mã học kì  ");
					txtMa.Focus();
					return;
				}

				string sqlInsert = " insert into LopHocPhan values ('" + txtMa.Text + "',N'" + txtTen.Text + "','" + txtSS.Text + "','" + txtTiLe.Text + "',N'" + txtDD.Text + "','" + cbbMHP.Text + "','" + cbbMaGV.Text + "','" + cbbMaHK.Text + "') ";
				data.DataChange(sqlInsert);
				LoadData();
				MessageBox.Show("Thêm thành công ");
				ResetValue();
			}
		}

		private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMa.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
			txtTen.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
			txtSS.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
			txtTiLe.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
			txtDD.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
			cbbMHP.Text = dgvData.CurrentRow.Cells[5].Value.ToString();
			cbbMaGV.Text = dgvData.CurrentRow.Cells[6].Value.ToString();
			cbbMaHK.Text = dgvData.CurrentRow.Cells[7].Value.ToString();
			btnThem.Enabled = false;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			data.DataChange("update LopHocPhan set MaLop='" + txtMa.Text + "',TenLop='" + txtTen.Text + "',SiSo='" + txtSS.Text + "',TiLeDiem='" + txtTiLe.Text + "',DiaDiem='" + txtDD.Text + "',MaHP='" + cbbMHP.SelectedValue + "',MaGV='" + cbbMaGV.SelectedValue + "',MaHK='" + cbbMaHK.SelectedValue + "' where MaLop='" + txtMa.Text + "'");
			LoadData();
			ResetValue();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay Không ", MessageBoxButtons.YesNo,
							   MessageBoxIcon.Question) == DialogResult.Yes)
					data.DataChange("delete LopHocPhan  where MaLop  = '" + txtMa.Text + "'");
				LoadData();
				ResetValue();
			}
			catch
			{
				MessageBox.Show("Lỗi khi xóa dữ liệu từ cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnRS_Click(object sender, EventArgs e)
		{
			ResetValue();
			LoadData();
		}

		private void btnEX_Click(object sender, EventArgs e)
		{
			DataTable dtGV = data.DataReader("SELECT * from  LopHocPhan");
			dgvData.DataSource = dtGV;
			Excel.Application exApp = new Excel.Application(); // app excel
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);//  thể hiện  file excel
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];// trang sheet(có 1 trang )
																			// in tiêu  đề
			Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];//  đua con  trỏ vào ô 1,1\
			exRange.Font.Size = 15;
			exRange.Font.Bold = true;
			exRange.Font.Color = Color.Blue;
			exRange.Value = "Trường ĐH TOP 1 ";

			Excel.Range diachi = (Excel.Range)exSheet.Cells[2, 1];
			diachi.Font.Size = 13;
			diachi.Font.Color = Color.Blue;
			diachi.Value = "Cầu Giấy-Hà Nội";

			//In Hoá Đơn Bán
			exSheet.Range["D4"].Font.Size = 18;
			exSheet.Range["D4"].Font.Bold = true;
			exSheet.Range["D4"].Font.Color = Color.Black;
			exSheet.Range["D4"].Value = "Danh Sách Sách  Giảng Viên";
			//định dạng dòng
			exSheet.Range["A6:I6"].Font.Size = 12;
			exSheet.Range["A6:I6"].Font.Bold = true;
			exSheet.Range["A6"].ColumnWidth = 4;
			exSheet.Range["D6"].ColumnWidth = 10;
			exSheet.Range["E6"].ColumnWidth = 25;
			exSheet.Range["F6"].ColumnWidth = 12;
			exSheet.Range["G6"].ColumnWidth = 12;
			exSheet.Range["I6"].ColumnWidth = 15;
			//In Dòng Tieu Đề
			exSheet.Range["A6"].Value = "STT";
			exSheet.Range["B6"].Value = "Mã Lớp";
			exSheet.Range["C6"].Value = "Tên Lớp";
			exSheet.Range["D6"].Value = "Sĩ Số";
			exSheet.Range["E6"].Value = "Tỉ Lệ Điểm";
			exSheet.Range["F6"].Value = "Địa Điểm";
			exSheet.Range["G6"].Value = "Mã Học Phần";
			exSheet.Range["H6"].Value = "Mã Giáo Viên";
			exSheet.Range["I6"].Value = "Mã Học Kì";



			//in ds chi tiết
			int dong = 7;
			for (int i = 0; i < dgvData.Rows.Count - 1; i++)
			{
				exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
				exSheet.Range["B" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[0].Value.ToString();
				exSheet.Range["C" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[1].Value.ToString();
				exSheet.Range["D" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[2].Value.ToString();
				exSheet.Range["E" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[3].Value.ToString();
				exSheet.Range["F" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[4].Value.ToString();
				exSheet.Range["G" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[5].Value.ToString();
				exSheet.Range["H" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[6].Value.ToString();
				exSheet.Range["I" + (dong + i).ToString()].Value = dgvData.Rows[i].Cells[7].Value.ToString();



				//căn lề trái excel
				exSheet.Range["A" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["G" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["H" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				exSheet.Range["I" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;




			}
			dong = dong + dgvData.Rows.Count;
			exSheet.Name = "DS Lớp Học Phần  ";


			if (dgvData.Rows.Count == 0)
			{
				MessageBox.Show("Không thể in vì không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				// Your existing code to activate, save, and quit Excel
				exBook.Activate();

				SaveFileDialog saveExcelSachQH = new SaveFileDialog();
				saveExcelSachQH.Filter = "Excel Workbook|*.xlsx|All Files|*.*";
				saveExcelSachQH.FilterIndex = 2;

				if (saveExcelSachQH.ShowDialog() == DialogResult.OK)
				{
					exBook.SaveAs(saveExcelSachQH.FileName.ToLower());
				}
				exApp.Quit();
			}
		}

		private void btnTK_Click(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM LopHocPhan where MaLop is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and MaLop like '%" + txtTK.Text + "%'";
			}
			dgvData.DataSource = data.DataReader(sql);
		}
	}
}