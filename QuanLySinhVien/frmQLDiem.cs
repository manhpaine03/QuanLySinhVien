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
using System.Windows.Shapes;
using Xceed.Wpf.AvalonDock.Themes;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLySinhVien
{
	public partial class frmQLDiem : Form
	{
		ProcessDataBase data = new ProcessDataBase();
		CommonFunctions function = new CommonFunctions();
		public frmQLDiem()
		{
			InitializeComponent();

		}

		public void ResetValue()
		{
			txtQT.Text = "";
			txtHK.Text = "";
		}

		void LoadDataTTSV()
		{
			DataTable dt = data.DataReader("SELECT SinhVien.MaSV, HoTen, HocPhan.MaHP, Hoc.MaLop, TenLop,  TenKhoa FROM dbo.SinhVien " +
						   " INNER JOIN dbo.Nganh ON Nganh.MaNganh = SinhVien.MaNganh" +
						   " INNER JOIN dbo.Khoa ON Khoa.MaKhoa = Nganh.MaKhoa" +
						   " INNER JOIN dbo.Hoc ON Hoc.MaSV = SinhVien.MaSV" +
						   " INNER JOIN dbo.LopHocPhan ON LopHocPhan.MaLop = Hoc.MaLop " +
						   " INNER JOIN dbo.HocPhan ON HocPhan.MaHP = LopHocPhan.MaHP " +
						   " WHERE TenKhoa = N'" + cbbKhoa.SelectedValue + "' AND TenLop = N'" + cbbLopHP.SelectedValue + "'");
			dgvSinhVien.DataSource = dt;
		}

		void LoadDataTTD()
		{
			DataTable dt = data.DataReader("SELECT SinhVien.MaSV, HoTen, Hoc.MaLop, TenLop, DiemQT, DiemHK, DiemTong, XepLoai  FROM dbo.SinhVien " +
				"INNER JOIN dbo.Hoc ON Hoc.MaSV = SinhVien.MaSV INNER JOIN dbo.LopHocPhan ON LopHocPhan.MaLop = Hoc.MaLop " +
				"INNER JOIN dbo.HocPhan ON HocPhan.MaHP = LopHocPhan.MaHP WHERE TenLop  = N'" + cbbLopHP.SelectedValue + "'");
			dgvTTD.DataSource = dt;
		}

		private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cbbKhoa_Click(object sender, EventArgs e)
		{
			cbbKhoa.DataSource = null;
			function.FillComboBox(cbbKhoa, data.DataReader("Select TenKhoa from Khoa"), "TenKhoa", "TenKhoa");
		}

		private void cbbLopHP_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void cbbHP_Click(object sender, EventArgs e)
		{
			cbbHP.DataSource = null;
			function.FillComboBox(cbbHP, data.DataReader("Select TenHP from HocPhan"), "TenHP", "TenHP");
		}

		private void cbbNamHoc_Click(object sender, EventArgs e)
		{
			cbbNamHoc.DataSource = null;
			function.FillComboBox(cbbNamHoc, data.DataReader("SELECT DISTINCT NamHoc FROM dbo.HocKi"), "NamHoc", "NamHoc");
		}

		private void cbbHocKi_Click(object sender, EventArgs e)
		{
			cbbHocKi.DataSource = null;
			function.FillComboBox(cbbHocKi, data.DataReader("SELECT DISTINCT HocKi FROM dbo.HocKi"), "HocKi", "HocKi");
		}
		private void cbbLopHP_Click(object sender, EventArgs e)
		{
			try
			{
				cbbLopHP.DataSource = null;
				function.FillComboBox(cbbLopHP, data.DataReader("SELECT TenLop FROM dbo.LopHocPhan " +
					"INNER JOIN dbo.HocKi ON HocKi.MaHK = LopHocPhan.MaHK " +
					"WHERE LopHocPhan.MaHP = (SELECT MaHP FROM dbo.HocPhan WHERE TenHP = N'" + cbbHP.SelectedValue + "') " +
					"AND dbo.LopHocPhan.MaHK = (SELECT MaHK FROM dbo.HocKi WHERE NamHoc = '" + cbbNamHoc.SelectedValue + "' AND HocKi = " + cbbHocKi.SelectedValue + ")"), "TenLop", "TenLop");
				LoadDataTTSV();
				LoadDataTTD();
			}
			catch
			{
				MessageBox.Show("Vui lòng chọn các lựa chọn ở trên");
			}

		}

		private void QLDiem_Load(object sender, EventArgs e)
		{

		}
		/*
        private void txtQT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = data.DataReader("SELECT TiLeDiem FROM LopHocPhan WHERE MaLop = N'" + txtMaLop + "'");
            if (dt.Rows.Count > 0)
            {
                string tiLeDiem = dt.Rows[0]["TiLeDiem"].ToString();
                double diemTong = 0;
                if(tiLeDiem == "5-5")
                {
                    diemTong = (Convert.ToDouble(txtQT.Text)+ Convert.ToDouble(txtHK.Text))/2;
                }
                else if(tiLeDiem == "4-6")
                {
                    diemTong = (Convert.ToDouble(txtQT.Text)*0.4 + Convert.ToDouble(txtHK.Text)*0.6);
                }
                txtTB.Text = diemTong.ToString();
            }
            

        }
        */

		private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvTTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaSv.Text = dgvTTD.CurrentRow.Cells[0].Value.ToString();
			txtHoTen.Text = dgvTTD.CurrentRow.Cells[1].Value.ToString();
			txtMaLop.Text = dgvTTD.CurrentRow.Cells[2].Value.ToString();
			txtTenLop.Text = dgvTTD.CurrentRow.Cells[3].Value.ToString();
			txtQT.Text = dgvTTD.CurrentRow.Cells[4].Value.ToString();
			txtHK.Text = dgvTTD.CurrentRow.Cells[5].Value.ToString();
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtQT.ReadOnly = false;
			txtHK.ReadOnly = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			txtQT.ReadOnly = false;
			txtHK.ReadOnly = false;
			btnThem.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					data.DataChange("delete Hoc where MaSV= '" + txtMaSv.Text + "'");
					LoadDataTTD();
				}
				catch
				{
					MessageBox.Show("Bạn không được xóa vì nó liên quan đến các thông tin khác.");
				}

			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (btnThem.Enabled == true)
			{
				if (txtQT.Text.Trim() == null)
				{
					MessageBox.Show("Vui lòng nhập điểm quá trình");
					txtQT.Focus();
				}
				else if (txtHK.Text.Trim() == null)
				{
					MessageBox.Show("Vui lòng nhập điểm học kì");
					txtHK.Focus();
				}
				else
				{
					DataTable dtCheck = data.DataReader("Select * from Hoc  where MaSV='" + txtMaSv.Text + "'");
					if (dtCheck.Rows.Count > 0)
					{
						MessageBox.Show("Đã có sinh viên này, mời thử lại ");
						return;
					}
					else
					{
						string sqlInsert = "INSERT INTO dbo.Hoc VALUES( N'" + txtMaSv.Text + "', N'" + txtMaLop.Text + "', " + txtQT.Text + " , " + txtHK.Text + ", NULL, NULL)";
						data.DataChange(sqlInsert);
						LoadDataTTD();
						MessageBox.Show("Thêm thành công ");

					}

				}
			}
			else if (btnSua.Enabled == true)
			{
				if (txtQT.Text.Trim() == null)
				{
					MessageBox.Show("Vui lòng nhập điểm quá trình");
					txtQT.Focus();
				}
				else if (txtHK.Text.Trim() == null)
				{
					MessageBox.Show("Vui lòng nhập điểm học kì");
					txtHK.Focus();
				}
				else
				{
					data.DataChange("update Hoc set DiemQT='" + txtQT.Text + "', DiemHK = '" + txtHK.Text + "' where MaSV = '" + txtMaSv.Text + "'");

				}
			}
			else
			{
				LoadDataTTD();
			}

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			btnThem.Enabled = true;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			txtHK.ReadOnly = true;
			txtQT.ReadOnly = true;
			ResetValue();
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			DataTable dt = data.DataReader("SELECT SinhVien.MaSV, HoTen, Hoc.MaLop, TenLop, DiemQT, DiemHK, DiemTong, XepLoai  FROM dbo.SinhVien" +
				" INNER JOIN dbo.Hoc ON Hoc.MaSV = SinhVien.MaSV INNER JOIN dbo.LopHocPhan ON LopHocPhan.MaLop = Hoc.MaLop " +
				" INNER JOIN dbo.HocPhan ON HocPhan.MaHP = LopHocPhan.MaHP WHERE TenLop  = N'" + cbbLopHP.SelectedValue + "'");
			if (dt.Rows.Count > 0)
			{
				Excel.Application exApp = new Excel.Application();
				Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Worksheet exSheet = (Excel.Worksheet)exApp.Worksheets[1];

				exSheet.Range["A1:A2"].Font.Size = 15;
				exSheet.Range["A1"].Value = "BỘ GIÁO DỤC VÀ ĐÀO TẠO";
				exSheet.Range["A2"].Value = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI";
				exSheet.Range["F1"].Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
				exSheet.Range["F2"].Value = "ĐỘC LÂP - TỰ DO - HẠNH PHÚC";
				exSheet.Range["D5"].Value = "DANH SÁCH SINH VIÊN LỚP HỌC PHẦN";

				Excel.Range header = (Excel.Range)exSheet.Cells[7, 4];
				header.Font.Size = 15;
				header.Font.Bold = true;
				header.Font.Color = Color.Red;
				header.Value = dt.Rows[1]["TenLop"].ToString();

				exSheet.get_Range("A10:I10").Font.Bold = true;
				exSheet.get_Range("A10:I10").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				exSheet.get_Range("A10").Value = "STT";
				exSheet.get_Range("B10").Value = "Mã SV";
				exSheet.get_Range("C10").Value = "Họ Tên";
				exSheet.get_Range("D10").Value = "Mã lớp";
				exSheet.get_Range("E10").Value = "Tên lớp";
				exSheet.get_Range("F10").Value = "Điểm QT";
				exSheet.get_Range("G10").Value = "Điểm HK";
				exSheet.get_Range("H10").Value = "Điểm tổng";
				exSheet.get_Range("I10").Value = "Xếp loại";

				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
				exSheet.get_Range("A10:I10").Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;


				for (int i = 0; i < dt.Rows.Count; i++)
				{
					// Set font bold for the entire range
					exSheet.get_Range("A" + (i + 11).ToString() + ":I" + (i + 11).ToString()).Font.Bold = true;
					// Set cell values                                         
					exSheet.get_Range("A" + (i + 11).ToString() + ":I" + (i + 11).ToString()).Value = (i + 1).ToString();
					// Set font bold again (not necessary, as it was already set above)
					exSheet.get_Range("A" + (i + 11).ToString() + ":I" + (i + 11).ToString()).Font.Bold = true;
					// Set values for other columns
					exSheet.get_Range("B" + (i + 11).ToString()).Value = dt.Rows[i]["MaSV"].ToString();
					exSheet.get_Range("C" + (i + 11).ToString()).Value = dt.Rows[i]["HoTen"].ToString();
					exSheet.get_Range("D" + (i + 11).ToString()).Value = dt.Rows[i]["MaLop"].ToString();
					exSheet.get_Range("E" + (i + 11).ToString()).Value = dt.Rows[i]["TenLop"].ToString();
					exSheet.get_Range("F" + (i + 11).ToString()).Value = dt.Rows[i]["DiemQT"].ToString();
					exSheet.get_Range("G" + (i + 11).ToString()).Value = dt.Rows[i]["DiemHK"].ToString();
					exSheet.get_Range("H" + (i + 11).ToString()).Value = dt.Rows[i]["DiemTong"].ToString();
					exSheet.get_Range("I" + (i + 11).ToString()).Value = dt.Rows[i]["XepLoai"].ToString();
					// Set bold borders for the entire range
					var range = exSheet.get_Range("A" + (i + 11).ToString() + ":I" + (i + 11).ToString()).Borders;
					range[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
					range[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThin;

					range[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
					range[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThin;

					range[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
					range[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThin;

					range[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
					range[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThin;

					exSheet.get_Range("C" + (i + 11).ToString()).EntireColumn.AutoFit();
					exSheet.get_Range("E" + (i + 11).ToString()).EntireColumn.AutoFit();
				}


				exSheet.Name = "DanhSachSinhVien";
				exBook.Activate();

				SaveFileDialog dlgSave = new SaveFileDialog();
				dlgSave.Filter = "Excel Document(*.xls)|*.xls|Word Document(*.doc)|*.doc|All Files(*.*)|*.*";
				dlgSave.FilterIndex = 1;
				dlgSave.AddExtension = true;
				dlgSave.DefaultExt = ".xls";
				if (dlgSave.ShowDialog() == DialogResult.OK)
					exBook.SaveAs(dlgSave.FileName.ToString());
				exApp.Quit();
				MessageBox.Show("Đã in thành công");
			}
			else
			{
				MessageBox.Show("Không có danh sách sinh viên để in");
			}
		}

		private void txtQT_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Kiểm tra xem ký tự nhập vào có phải là số thập phân hoặc ký tự chấp nhận (dot '.')
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true; // Từ chối ký tự không hợp lệ
				MessageBox.Show("Bạn chỉ được nhập số thập phân từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra xem ký tự '.' có xuất hiện đúng một lần hay không
			if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
			{
				e.Handled = true; // Từ chối thêm ký tự '.'
				MessageBox.Show("Bạn chỉ được nhập một dấu chấm thập phân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra giá trị tổng cộng sau khi thêm ký tự mới
			string newText = ((TextBox)sender).Text + e.KeyChar;
			if (!IsValidDecimalNumber(newText))
			{
				e.Handled = true; // Từ chối ký tự không hợp lệ
				MessageBox.Show("Giá trị phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private bool IsValidDecimalNumber(string text)
		{
			// Kiểm tra giá trị số thập phân hợp lệ
			if (double.TryParse(text, out double number))
			{
				return (number >= 0 || number <= 10);
			}

			return false;
		}
	}
}
