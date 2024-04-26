namespace QuanLySinhVien
{
	partial class frmDangKyHP
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbbLopHP = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbbTenHP = new System.Windows.Forms.ComboBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvSinhVien = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.dgvSinhVien);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtTK);
			this.groupBox1.Location = new System.Drawing.Point(37, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1006, 217);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thêm sinh viên";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.cbbLopHP);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbbTenHP);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(476, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(512, 151);
			this.panel1.TabIndex = 44;
			// 
			// cbbLopHP
			// 
			this.cbbLopHP.FormattingEnabled = true;
			this.cbbLopHP.Location = new System.Drawing.Point(89, 81);
			this.cbbLopHP.Name = "cbbLopHP";
			this.cbbLopHP.Size = new System.Drawing.Size(233, 26);
			this.cbbLopHP.TabIndex = 43;
			this.cbbLopHP.SelectedIndexChanged += new System.EventHandler(this.cbbLopHP_SelectedIndexChanged);
			this.cbbLopHP.Click += new System.EventHandler(this.cbbLopHP_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 42;
			this.label2.Text = "Tên HP:";
			// 
			// cbbTenHP
			// 
			this.cbbTenHP.FormattingEnabled = true;
			this.cbbTenHP.Location = new System.Drawing.Point(89, 13);
			this.cbbTenHP.Name = "cbbTenHP";
			this.cbbTenHP.Size = new System.Drawing.Size(137, 26);
			this.cbbTenHP.TabIndex = 41;
			this.cbbTenHP.SelectedIndexChanged += new System.EventHandler(this.cbbTenHP_SelectedIndexChanged);
			this.cbbTenHP.Click += new System.EventHandler(this.cbbTenHP_Click);
			// 
			// btnThem
			// 
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px;
			this.btnThem.Location = new System.Drawing.Point(383, 7);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 36);
			this.btnThem.TabIndex = 39;
			this.btnThem.Text = "   Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 18);
			this.label1.TabIndex = 38;
			this.label1.Text = "Lớp HP:";
			// 
			// dgvSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
			this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinhVien.Location = new System.Drawing.Point(21, 87);
			this.dgvSinhVien.Name = "dgvSinhVien";
			this.dgvSinhVien.ReadOnly = true;
			this.dgvSinhVien.RowHeadersWidth = 51;
			this.dgvSinhVien.RowTemplate.Height = 24;
			this.dgvSinhVien.Size = new System.Drawing.Size(387, 112);
			this.dgvSinhVien.TabIndex = 40;
			this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(18, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 18);
			this.label10.TabIndex = 35;
			this.label10.Text = "Mã SV:";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search_24px;
			this.btnTimKiem.Location = new System.Drawing.Point(295, 29);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(114, 36);
			this.btnTimKiem.TabIndex = 34;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(89, 35);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(152, 24);
			this.txtTK.TabIndex = 36;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.dgvLopHocPhan);
			this.groupBox2.Location = new System.Drawing.Point(37, 255);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1006, 416);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách sinh viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 388);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 18);
			this.label3.TabIndex = 36;
			this.label3.Text = "Nhấp đúp để xóa";
			// 
			// dgvLopHocPhan
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			this.dgvLopHocPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvLopHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvLopHocPhan.BackgroundColor = System.Drawing.Color.White;
			this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLopHocPhan.Location = new System.Drawing.Point(21, 40);
			this.dgvLopHocPhan.Name = "dgvLopHocPhan";
			this.dgvLopHocPhan.ReadOnly = true;
			this.dgvLopHocPhan.RowHeadersWidth = 51;
			this.dgvLopHocPhan.RowTemplate.Height = 24;
			this.dgvLopHocPhan.Size = new System.Drawing.Size(952, 345);
			this.dgvLopHocPhan.TabIndex = 0;
			this.dgvLopHocPhan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHocPhan_CellContentDoubleClick);
			// 
			// frmDangKyHP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 739);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmDangKyHP";
			this.Text = "frmChiTietLHP";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox txtTK;
		private System.Windows.Forms.DataGridView dgvSinhVien;
		private System.Windows.Forms.DataGridView dgvLopHocPhan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbTenHP;
		private System.Windows.Forms.ComboBox cbbLopHP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}