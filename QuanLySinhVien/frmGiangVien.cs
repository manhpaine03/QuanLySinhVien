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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;

namespace QuanLySinhVien
{
    public partial class frmGiangVien : Form
    {
        ProcessDataBase data = new ProcessDataBase();
        CommonFunctions function = new CommonFunctions();
        string fileAnh;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable dtHang = data.DataReader("select * from GiangVien");
            dgvData.DataSource = dtHang;
        }

        void ResetValue()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEMAIL.Text = "";
            txtCM.Text = "";
            fileAnh = "";
            txtMa.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //picAnh.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlSelect = "select * from GiangVien";
            DataTable dt = data.DataReader(sqlSelect);
            dgvData.DataSource = dt;
            dgvData.Columns[0].HeaderText = "Mã GV ";
            dgvData.Columns[1].HeaderText = "Tên GV ";
            dgvData.Columns[2].HeaderText = "SĐT";
            dgvData.Columns[3].HeaderText = "Email ";
            dgvData.Columns[4].HeaderText = "Chuyên môn ";
            dgvData.BackgroundColor = SystemColors.Window;
            ResetValue();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dtCheckhang = data.DataReader("Select * from GiangVien  where MaGV='" + txtMa.Text + "'");
            if (txtMa.Text == "")
            {
                MessageBox.Show("Cần nhập mã Giảng Viên  ");
                txtMa.Focus();
                return;
            }
            else
            {
                if (dtCheckhang.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Giảng viên đã có, mời lại ");
                    ResetValue();
                    txtMa.Focus();
                    return;
                }

                if (txtTen.Text == "")
                {
                    MessageBox.Show("Không được để trống Tên giảng viên ");
                    txtTen.Focus();
                    return;
                }

                if (txtSDT.Text == "")
                {
                    MessageBox.Show("Không được để trống Số điện thoại giảng viên ");
                    txtMa.Focus();
                    return;
                }

                if (txtEMAIL.Text == "")
                {
                    MessageBox.Show("Không được để trống Email giảng viên ");
                    txtMa.Focus();
                    return;
                }

                if (txtCM.Text == "")
                {
                    MessageBox.Show("Không được để trống Chuyên môn giảng viên ");
                    txtMa.Focus();
                    return;
                }

                string sqlInsert = " insert into GiangVien values ('" + txtMa.Text + "',N'" + txtTen.Text + "','" + txtSDT.Text + "','" + txtEMAIL.Text + "',N'" + txtCM.Text + "','" + fileAnh + "') ";
                data.DataChange(sqlInsert);
                LoadData();
                MessageBox.Show("Thêm thành công ");
                ResetValue();
            }

        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG images|* .jpg|PNG images|*.png|All files|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory = Application.StartupPath;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(openFile.FileName);
                image = openFile.FileName.ToString().Split('/');
                fileAnh = image[image.Length - 1];
                MessageBox.Show(fileAnh);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvData.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
            txtEMAIL.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
            txtCM.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
            fileAnh = dgvData.CurrentRow.Cells[5].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\img-GV\\" + fileAnh);
            }
            catch
            {
                picAnh = null;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data.DataChange("update GiangVien set MaGV='" + txtMa.Text + "',TenGV='" + txtTen.Text + "',SoDT='" + txtSDT.Text + "',Email='" + txtEMAIL.Text + "',ChuyenMon='" + txtCM.Text + "',AnhGV='" + fileAnh + "' where MaGV='" + txtMa.Text + "'");
            LoadData();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay Không ", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                data.DataChange("delete GiangVien  where MaGV  = '" + txtMa.Text + "'");
            LoadData();
            ResetValue();
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadData();
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            DataTable dtGV = data.DataReader("SELECT * from  GiangVien");
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
            exSheet.Range["B6"].Value = "Mã Giảng Viên";
            exSheet.Range["C6"].Value = "Tên Giảng Viên";
            exSheet.Range["D6"].Value = "SDT";
            exSheet.Range["E6"].Value = "Email";
            exSheet.Range["F6"].Value = "Chuyên môn";


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

                //căn lề trái excel
                exSheet.Range["A" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                exSheet.Range["G" + (dong + i).ToString()].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;


            }
            dong = dong + dgvData.Rows.Count;
            exSheet.Name = "DS Giảng Viên ";


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
			string sql = "SELECT * FROM GiangVien where MaGV is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and MaGV like '%" + txtTK.Text + "%'";
			}
			DataTable dt = data.DataReader(sql);
			if (dt.Rows.Count > 0)
			{
				dgvData.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có giảng viên này");
			}
		}

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
			{
				MessageBox.Show("Bạn chỉ được nhập số nguyên");
				e.Handled = true;
			}
		}
	}
}
