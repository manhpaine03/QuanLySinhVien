using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace QuanLySinhVien
{

	public partial class frmQuanLy : Form
	{
        //Fields
      
        public frmQuanLy()
		{
			InitializeComponent();
			InitializeUI();
		}

		private void InitializeUI()
		{
            labelTitle.Text = "Chào mừng bạn đến với phần mềm quản lý sinh viên";
			// Đặt label vào giữa panel
			CenterLabelInPanel();
		}

		private void CenterLabelInPanel()
		{
			int x = (panelTitle.Width - labelTitle.Width) / 2;
			int y = (panelTitle.Height - labelTitle.Height) / 2;

			labelTitle.Location = new Point(x, y);
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			// Khi form được thay đổi kích thước, đặt lại vị trí của label
			CenterLabelInPanel();
		}


		public void OpenForm(Form frm)
        {
            // Đóng tất cả các form hiện tại trong Panel
            foreach (Control control in panel1.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                }
            }

            // Lưu kích thước hiện tại của form
            Size currentSize = frm.Size;

            // Thêm form mới vào Panel
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            frm.ClientSize = panel1.ClientSize;

            panel1.Controls.Add(frm);   

            // Điều chỉnh kích thước của các thành phần trong form tương ứng với tỉ lệ thay đổi
            foreach (Control control in frm.Controls)
            {
                control.Width = (int)Math.Round(control.Width * ((double)frm.ClientSize.Width / currentSize.Width));
                control.Height = (int)Math.Round(control.Height * ((double)frm.ClientSize.Height / currentSize.Height));
                control.Left = (int)Math.Round(control.Left * ((double)frm.ClientSize.Width / currentSize.Width));
                control.Top = (int)Math.Round(control.Top * ((double)frm.ClientSize.Height / currentSize.Height));
            }         

            frm.Show();
        }

 

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVien frm = new frmSinhVien();
            OpenForm(frm);

            labelTitle.Text = "Thông tin chi tiết sinh viên";
			CenterLabelInPanel();
		}

        private void btnGiangVien_Click(object sender, EventArgs e)
        {   
            frmGiangVien frmGV = new frmGiangVien();
            OpenForm(frmGV);

			labelTitle.Text = "Thông tin chi tiết giảng viên";
			CenterLabelInPanel();
		}

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            frmHocPhan frmHP = new frmHocPhan();
            OpenForm(frmHP);

			labelTitle.Text = "Thông tin chi tiết học phần";
			CenterLabelInPanel();
		}

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmQLDiem frmDiem = new frmQLDiem();
            OpenForm(frmDiem);

			labelTitle.Text = "Quản lý thông tin điểm";
			CenterLabelInPanel();
		}

        private void btnLopHP_Click(object sender, EventArgs e)
        {
            frmLopHocPhan frm = new frmLopHocPhan();
            OpenForm(frm);

			labelTitle.Text = "Lớp học phần";
			CenterLabelInPanel();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            frmQLKhoa frm= new frmQLKhoa();
            OpenForm(frm);

			labelTitle.Text = "Quản lý khoa";
			CenterLabelInPanel();
		}

		private void btnDangKyHP_Click(object sender, EventArgs e)
		{
			frmDangKyHP frm = new frmDangKyHP();
			OpenForm(frm);

			labelTitle.Text = "Đăng kí học phần";
			CenterLabelInPanel();
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{

		}
	}
}
