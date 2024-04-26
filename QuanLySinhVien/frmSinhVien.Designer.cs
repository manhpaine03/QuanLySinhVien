namespace QuanLySinhVien
{
    partial class frmSinhVien
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
			this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
			this.cbbMaNganh = new System.Windows.Forms.ComboBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtQueQuan = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaSinhVien = new System.Windows.Forms.TextBox();
			this.txtsdt = new System.Windows.Forms.TextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvDanhSach = new System.Windows.Forms.DataGridView();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.btnRS = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnChonAnh = new System.Windows.Forms.Button();
			this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbbGioiTinh);
			this.groupBox1.Controls.Add(this.cbbTinhTrang);
			this.groupBox1.Controls.Add(this.cbbMaNganh);
			this.groupBox1.Controls.Add(this.btnChonAnh);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.picAnhDaiDien);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtQueQuan);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtMaSinhVien);
			this.groupBox1.Controls.Add(this.txtsdt);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.txtemail);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(22, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1043, 345);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên";
			// 
			// cbbGioiTinh
			// 
			this.cbbGioiTinh.FormattingEnabled = true;
			this.cbbGioiTinh.Location = new System.Drawing.Point(146, 302);
			this.cbbGioiTinh.Name = "cbbGioiTinh";
			this.cbbGioiTinh.Size = new System.Drawing.Size(74, 26);
			this.cbbGioiTinh.TabIndex = 41;
			// 
			// cbbTinhTrang
			// 
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.Location = new System.Drawing.Point(677, 154);
			this.cbbTinhTrang.Name = "cbbTinhTrang";
			this.cbbTinhTrang.Size = new System.Drawing.Size(185, 26);
			this.cbbTinhTrang.TabIndex = 42;
			// 
			// cbbMaNganh
			// 
			this.cbbMaNganh.FormattingEnabled = true;
			this.cbbMaNganh.Items.AddRange(new object[] {
            "CNPM      ",
            "CTM       ",
            "KHMT      ",
            "VTDB      ",
            "VTDS      "});
			this.cbbMaNganh.Location = new System.Drawing.Point(145, 255);
			this.cbbMaNganh.Name = "cbbMaNganh";
			this.cbbMaNganh.Size = new System.Drawing.Size(145, 26);
			this.cbbMaNganh.TabIndex = 40;
			this.cbbMaNganh.SelectedIndexChanged += new System.EventHandler(this.cbbMaNganh_SelectedIndexChanged);
			this.cbbMaNganh.Click += new System.EventHandler(this.cbbMaNganh_Click);
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(145, 44);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(248, 24);
			this.txtHoTen.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(25, 263);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 18);
			this.label9.TabIndex = 26;
			this.label9.Text = "Mã Ngành:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 18);
			this.label1.TabIndex = 18;
			this.label1.Text = "Họ tên:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Mã sinh viên:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(547, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 18);
			this.label6.TabIndex = 23;
			this.label6.Text = "Email:";
			// 
			// txtQueQuan
			// 
			this.txtQueQuan.Location = new System.Drawing.Point(145, 207);
			this.txtQueQuan.Name = "txtQueQuan";
			this.txtQueQuan.Size = new System.Drawing.Size(199, 24);
			this.txtQueQuan.TabIndex = 33;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(547, 99);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 18);
			this.label8.TabIndex = 25;
			this.label8.Text = "Số điện thoại:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 213);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 18);
			this.label7.TabIndex = 24;
			this.label7.Text = "Quê quán:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(547, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 18);
			this.label5.TabIndex = 22;
			this.label5.Text = "Tình trạng học:";
			// 
			// txtMaSinhVien
			// 
			this.txtMaSinhVien.Location = new System.Drawing.Point(145, 93);
			this.txtMaSinhVien.Name = "txtMaSinhVien";
			this.txtMaSinhVien.Size = new System.Drawing.Size(199, 24);
			this.txtMaSinhVien.TabIndex = 28;
			// 
			// txtsdt
			// 
			this.txtsdt.Location = new System.Drawing.Point(677, 93);
			this.txtsdt.Name = "txtsdt";
			this.txtsdt.Size = new System.Drawing.Size(186, 24);
			this.txtsdt.TabIndex = 34;
			this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgaySinh.Location = new System.Drawing.Point(145, 153);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(199, 24);
			this.dtpNgaySinh.TabIndex = 29;
			// 
			// txtemail
			// 
			this.txtemail.Location = new System.Drawing.Point(677, 44);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(248, 24);
			this.txtemail.TabIndex = 32;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 18);
			this.label3.TabIndex = 20;
			this.label3.Text = "Ngày sinh:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 310);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 21;
			this.label4.Text = "Giới tính:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvDanhSach);
			this.groupBox2.Location = new System.Drawing.Point(22, 437);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1043, 272);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách sinh viên";
			// 
			// dgvDanhSach
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
			this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSach.Location = new System.Drawing.Point(7, 30);
			this.dgvDanhSach.Name = "dgvDanhSach";
			this.dgvDanhSach.ReadOnly = true;
			this.dgvDanhSach.RowHeadersWidth = 51;
			this.dgvDanhSach.RowTemplate.Height = 24;
			this.dgvDanhSach.Size = new System.Drawing.Size(1022, 225);
			this.dgvDanhSach.TabIndex = 0;
			this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(673, 398);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(248, 24);
			this.txtTK.TabIndex = 33;
			this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(670, 377);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 18);
			this.label10.TabIndex = 20;
			this.label10.Text = "Mã sinh viên:";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search_24px;
			this.btnTimKiem.Location = new System.Drawing.Point(951, 378);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(114, 44);
			this.btnTimKiem.TabIndex = 8;
			this.btnTimKiem.Text = " Tìm kiếm";
			this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// btnRS
			// 
			this.btnRS.Image = global::QuanLySinhVien.Properties.Resources.reset;
			this.btnRS.Location = new System.Drawing.Point(504, 378);
			this.btnRS.Name = "btnRS";
			this.btnRS.Size = new System.Drawing.Size(114, 44);
			this.btnRS.TabIndex = 7;
			this.btnRS.Text = "  Reset";
			this.btnRS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRS.UseVisualStyleBackColor = true;
			this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(348, 378);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(114, 44);
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "   Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icon_change_24px;
			this.btnSua.Location = new System.Drawing.Point(198, 378);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 44);
			this.btnSua.TabIndex = 5;
			this.btnSua.Text = "   Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.White;
			this.btnThem.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px1;
			this.btnThem.Location = new System.Drawing.Point(50, 378);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "   Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnChonAnh
			// 
			this.btnChonAnh.Image = global::QuanLySinhVien.Properties.Resources.image_;
			this.btnChonAnh.Location = new System.Drawing.Point(550, 213);
			this.btnChonAnh.Name = "btnChonAnh";
			this.btnChonAnh.Size = new System.Drawing.Size(114, 44);
			this.btnChonAnh.TabIndex = 37;
			this.btnChonAnh.Text = " Chọn Ảnh";
			this.btnChonAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnChonAnh.UseVisualStyleBackColor = true;
			this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
			// 
			// picAnhDaiDien
			// 
			this.picAnhDaiDien.Location = new System.Drawing.Point(745, 210);
			this.picAnhDaiDien.Name = "picAnhDaiDien";
			this.picAnhDaiDien.Size = new System.Drawing.Size(118, 118);
			this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAnhDaiDien.TabIndex = 36;
			this.picAnhDaiDien.TabStop = false;
			// 
			// frmSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(1085, 721);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.btnRS);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmSinhVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSinhVien";
			this.Load += new System.EventHandler(this.frmSinhVien_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.ComboBox cbbTinhTrang;
		private System.Windows.Forms.Button btnChonAnh;
		private System.Windows.Forms.PictureBox picAnhDaiDien;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtsdt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbbGioiTinh;
		private System.Windows.Forms.ComboBox cbbMaNganh;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQueQuan;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMaSinhVien;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
	}
}