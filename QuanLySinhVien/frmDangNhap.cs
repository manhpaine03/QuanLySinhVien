using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Classes;
using QuanLySinhVien.Classes;

namespace QuanLySinhVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin đăng nhập từ người dùng.
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            // Kết nối với cơ sở dữ liệu.
            SqlConnection conn = new SqlConnection("Data Source=ANLAP\\LAP_AN;Initial Catalog=QuanLySinhVien;Integrated Security=True;");
            conn.Open();

            // Truy vấn cơ sở dữ liệu để tìm kiếm người dùng.
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau", conn);
            cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
            cmd.Parameters.AddWithValue("@MatKhau", matKhau);
            SqlDataReader reader = cmd.ExecuteReader();

            // So sánh thông tin đăng nhập của người dùng với thông tin trong cơ sở dữ liệu.
            if (reader.Read())
            {
                // Thông tin đăng nhập chính xác.
                if (MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo") == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                // Cho phép người dùng truy cập ứng dụng.
                frmQuanLy frmQL = new frmQuanLy();
                frmQL.ShowDialog();
                // ...
            }
            else
            {
                // Thông tin đăng nhập không chính xác.
                MessageBox.Show("Thông tin đăng nhập không chính xác");
                // Thông báo lỗi cho người dùng.
                // ...
            }

            // Đóng kết nối với cơ sở dữ liệu.
            conn.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
