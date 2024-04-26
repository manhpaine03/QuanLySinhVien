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

namespace QuanLySinhVien
{

	public partial class frmHocPhan : Form
	{
		ProcessDataBase data = new ProcessDataBase();
		CommonFunctions function = new CommonFunctions();
		public frmHocPhan()
		{
			InitializeComponent();
		}

		void LoadData()
		{
			DataTable dt = data.DataReader("SELECT * FROM dbo.HocPhan");
			dgvHocPhan.DataSource = dt;
		}

		public void ResetValue()
		{
			txtMaHP.Text = "";
			txtSoTC.Text = "";
			txtSoTiet.Text = "";
			txtTenHP.Text = "";
		}

		public void ResetTextBox(bool l)
		{
			txtMaHP.ReadOnly = l;
			txtSoTC.ReadOnly = l;
			txtSoTiet.ReadOnly = l;
			txtTenHP.ReadOnly = l;

		}

		private void frmHocPhan_Load(object sender, EventArgs e)
		{
			LoadData();
			ResetTextBox(true);
			btnCapNhat.Enabled = false;
		}


		private void btnThem_Click(object sender, EventArgs e)
		{
			ResetValue();
			ResetTextBox(false);
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			btnCapNhat.Enabled = true;
			txtMaHP.Focus();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			ResetTextBox(false);
			btnThem.Enabled = false;
			btnCapNhat.Enabled = true;
			txtMaHP.Focus();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					data.DataChange("delete HocPhan where MaHP = '" + txtMaHP.Text + "'");
					LoadData();
					ResetValue();
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
				if (txtMaHP.Text.Trim() == null)
				{
					MessageBox.Show("Không được để trống mã học phần ");
					txtMaHP.Focus();
					return;
				}
				else if (txtTenHP.Text.Trim() == null)
				{
					MessageBox.Show("Không được để trống tên học phần ");
					txtTenHP.Focus();
					return;
				}
				else if (txtSoTC.Text.Trim() == null)
				{
					MessageBox.Show("Không được để trống số tín chỉ ");
					txtSoTC.Focus();
					return;
				}
				else if (txtSoTiet.Text.Trim() == null)
				{
					MessageBox.Show("Không được để trống số tiết ");
					txtSoTiet.Focus();
					return;
				}
				else
				{
					//Kiểm tra
					DataTable dt = data.DataReader("Select * from HocPhan where MaHP = '" + txtMaHP + "'");
					if (dt.Rows.Count > 0)
					{
						MessageBox.Show("Mã học phần đã có mời bạn nhập mã khác");
						txtMaHP.Focus();
						return;
					}
					string sqlInsert = " insert into HocPhan values ('" + txtMaHP.Text + "',N'" + txtTenHP.Text + "','" + txtSoTC.Text + "','" + txtSoTiet.Text + "') ";
					data.DataChange(sqlInsert);
					LoadData();
					MessageBox.Show("Thêm thành công ");
					ResetValue();
				}
			}
			else if (btnSua.Enabled == true)
			{
				//Kiểm tra
				DataTable dt = data.DataReader("Select * from HocPhan where MaHP = '" + txtMaHP + "'");
				if (dt.Rows.Count > 0)
				{
					MessageBox.Show("Mã học phần đã có mời bạn nhập mã khác");
					txtMaHP.Focus();
					return;
				}
				else
				{
					data.DataChange("update HocPhan set MaHP='" + txtMaHP.Text
									+ "',TenHP='" + txtTenHP.Text + "',SoTC='" + txtSoTC.Text + "',SoTiet='"
									+ txtSoTiet.Text + "' where MaHP = '" + txtMaHP.Text + "'");
					LoadData();
					ResetValue();
				}
			}
		}


		private void btnHuy_Click(object sender, EventArgs e)
		{
			ResetValue();
			btnThem.Enabled = true;
			btnCapNhat.Enabled = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
		}

		private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ResetTextBox(true);
			btnThem.Enabled = false;
			btnXoa.Enabled = true;
			btnSua.Enabled = true;
			txtMaHP.Text = dgvHocPhan.CurrentRow.Cells[0].Value.ToString();
			txtTenHP.Text = dgvHocPhan.CurrentRow.Cells[1].Value.ToString();
			txtSoTC.Text = dgvHocPhan.CurrentRow.Cells[2].Value.ToString();
			txtSoTiet.Text = dgvHocPhan.CurrentRow.Cells[3].Value.ToString();
		}

		private void dgvHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM HocPhan where TenHP is not null ";
			if (txtTK.Text.Trim() != "")
			{
				sql += " and TenHP like '%" + txtTK.Text + "%'";
			}
			DataTable dt = data.DataReader(sql);
			if (dt.Rows.Count > 0)
			{
				dgvHocPhan.DataSource = dt;
			}
			else
			{
				MessageBox.Show("Không có học phần này");
			}
		}
	}
}
