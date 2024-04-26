using QuanLyBanHang.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmQLKhoa : Form
    {
        ProcessDataBase data = new ProcessDataBase();
        public frmQLKhoa()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            DataTable dtKhoa = data.DataReader("select * from Khoa");
            dgvKhoa.DataSource = dtKhoa;
        }
        void ResetValue()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtSoDT.Text = "";
            txtMaKhoa.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            string sqlSelect = "select * from Khoa";
            DataTable dt = data.DataReader(sqlSelect);
            dgvKhoa.DataSource = dt;
            dgvKhoa.Columns[0].HeaderText = "Mã Khoa";
            dgvKhoa.Columns[1].HeaderText = "Tên Khoa";
            dgvKhoa.Columns[2].HeaderText = "Số Điện Thoại";
            dgvKhoa.BackgroundColor = SystemColors.Window;
            ResetValue();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dtCheckhang = data.DataReader("Select * from Khoa  where MaKhoa='" + txtMaKhoa.Text + "'");
            if (dtCheckhang.Rows.Count > 0)
            {
                MessageBox.Show("Mã Khoa đã có, mời lại ");
                txtMaKhoa.Focus();
                return;
            }
            else
            {

                if (txtMaKhoa.Text == "")
                {
                    MessageBox.Show("Không được để trống mã khoa ");
                    txtMaKhoa.Focus();
                    return;
                }
                if (txtTenKhoa.Text == "")
                {
                    MessageBox.Show("Không được để trống tên khoa ");
                    txtTenKhoa.Focus();
                    return;
                }
                if (txtSoDT.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống số điện thoại ");
                    txtSoDT.Focus();
                    return;
                }
                string sqlInsert = " insert into Khoa values ('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "','" + txtSoDT.Text + "') ";
                data.DataChange(sqlInsert);
                LoadData();
                MessageBox.Show("Thêm thành công ");
                ResetValue();
            }
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dgvKhoa.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text = dgvKhoa.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            data.DataChange("update Khoa set MaKhoa='" + txtMaKhoa.Text + "',TenKhoa='" + txtTenKhoa.Text + "',SoDT='" + txtSoDT.Text + "'");
            LoadData();
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không ?", "Có hay Không ", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
                data.DataChange("delete Khoa  where MaKhoa  = '" + txtMaKhoa.Text + "'");
            LoadData();
            ResetValue();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
			string sql = "SELECT * FROM Khoa where MaKhoa is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and MaKhoa like '%" + txtTK.Text + "%'";
			}
			DataTable dt = data.DataReader(sql);
			if (dt.Rows.Count > 0)
			{
				dgvKhoa.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có khoa này, vui lòng thử lại");
			}
		}

		private void txtSoDT_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
			{
				MessageBox.Show("Bạn chỉ được nhập số nguyên");
				e.Handled = true;
			}
		}
	}
}
