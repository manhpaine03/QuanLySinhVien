namespace QuanLySinhVien
{
    partial class frmQLDiem
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
			this.cbbNamHoc = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbbHocKi = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbbHP = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvSinhVien = new System.Windows.Forms.DataGridView();
			this.cbbLopHP = new System.Windows.Forms.ComboBox();
			this.cbbKhoa = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtHK = new System.Windows.Forms.TextBox();
			this.txtQT = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dgvTTD = new System.Windows.Forms.DataGridView();
			this.txtTenLop = new System.Windows.Forms.TextBox();
			this.txtMaLop = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtMaSv = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTTD)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbbNamHoc);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbbHocKi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbbHP);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dgvSinhVien);
			this.groupBox1.Controls.Add(this.cbbLopHP);
			this.groupBox1.Controls.Add(this.cbbKhoa);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(14, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1029, 344);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin sinh viên";
			// 
			// cbbNamHoc
			// 
			this.cbbNamHoc.FormattingEnabled = true;
			this.cbbNamHoc.Location = new System.Drawing.Point(673, 24);
			this.cbbNamHoc.Name = "cbbNamHoc";
			this.cbbNamHoc.Size = new System.Drawing.Size(162, 26);
			this.cbbNamHoc.TabIndex = 14;
			this.cbbNamHoc.Click += new System.EventHandler(this.cbbNamHoc_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(560, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "Năm học";
			// 
			// cbbHocKi
			// 
			this.cbbHocKi.FormattingEnabled = true;
			this.cbbHocKi.Location = new System.Drawing.Point(673, 70);
			this.cbbHocKi.Name = "cbbHocKi";
			this.cbbHocKi.Size = new System.Drawing.Size(83, 26);
			this.cbbHocKi.TabIndex = 12;
			this.cbbHocKi.Click += new System.EventHandler(this.cbbHocKi_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(560, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 18);
			this.label4.TabIndex = 11;
			this.label4.Text = "Học kì";
			// 
			// cbbHP
			// 
			this.cbbHP.FormattingEnabled = true;
			this.cbbHP.Location = new System.Drawing.Point(223, 70);
			this.cbbHP.Name = "cbbHP";
			this.cbbHP.Size = new System.Drawing.Size(237, 26);
			this.cbbHP.TabIndex = 10;
			this.cbbHP.Click += new System.EventHandler(this.cbbHP_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(61, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 18);
			this.label3.TabIndex = 9;
			this.label3.Text = "Học phần";
			// 
			// dgvSinhVien
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
			this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSinhVien.Location = new System.Drawing.Point(29, 171);
			this.dgvSinhVien.Name = "dgvSinhVien";
			this.dgvSinhVien.ReadOnly = true;
			this.dgvSinhVien.RowHeadersWidth = 51;
			this.dgvSinhVien.RowTemplate.Height = 24;
			this.dgvSinhVien.Size = new System.Drawing.Size(967, 161);
			this.dgvSinhVien.TabIndex = 8;
			// 
			// cbbLopHP
			// 
			this.cbbLopHP.FormattingEnabled = true;
			this.cbbLopHP.Location = new System.Drawing.Point(223, 122);
			this.cbbLopHP.Name = "cbbLopHP";
			this.cbbLopHP.Size = new System.Drawing.Size(237, 26);
			this.cbbLopHP.TabIndex = 7;
			this.cbbLopHP.SelectedIndexChanged += new System.EventHandler(this.cbbLopHP_SelectedIndexChanged);
			this.cbbLopHP.Click += new System.EventHandler(this.cbbLopHP_Click);
			// 
			// cbbKhoa
			// 
			this.cbbKhoa.FormattingEnabled = true;
			this.cbbKhoa.Location = new System.Drawing.Point(223, 24);
			this.cbbKhoa.Name = "cbbKhoa";
			this.cbbKhoa.Size = new System.Drawing.Size(237, 26);
			this.cbbKhoa.TabIndex = 6;
			this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
			this.cbbKhoa.Click += new System.EventHandler(this.cbbKhoa_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Lớp học phần";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 18);
			this.label1.TabIndex = 4;
			this.label1.Text = "Khoa";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtHK);
			this.groupBox2.Controls.Add(this.txtQT);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.dgvTTD);
			this.groupBox2.Controls.Add(this.txtTenLop);
			this.groupBox2.Controls.Add(this.txtMaLop);
			this.groupBox2.Controls.Add(this.txtHoTen);
			this.groupBox2.Controls.Add(this.txtMaSv);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(14, 364);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1029, 308);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin điểm";
			// 
			// txtHK
			// 
			this.txtHK.Location = new System.Drawing.Point(927, 34);
			this.txtHK.Name = "txtHK";
			this.txtHK.ReadOnly = true;
			this.txtHK.Size = new System.Drawing.Size(69, 24);
			this.txtHK.TabIndex = 18;
			this.txtHK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQT_KeyPress);
			// 
			// txtQT
			// 
			this.txtQT.Location = new System.Drawing.Point(753, 34);
			this.txtQT.Name = "txtQT";
			this.txtQT.ReadOnly = true;
			this.txtQT.Size = new System.Drawing.Size(69, 24);
			this.txtQT.TabIndex = 17;
			this.txtQT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQT_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(850, 37);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(68, 18);
			this.label12.TabIndex = 16;
			this.label12.Text = "Điểm HK";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(666, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 18);
			this.label10.TabIndex = 14;
			this.label10.Text = "Điểm QT";
			// 
			// dgvTTD
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvTTD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTTD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTTD.BackgroundColor = System.Drawing.Color.White;
			this.dgvTTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTTD.Location = new System.Drawing.Point(29, 125);
			this.dgvTTD.Name = "dgvTTD";
			this.dgvTTD.ReadOnly = true;
			this.dgvTTD.RowHeadersWidth = 51;
			this.dgvTTD.RowTemplate.Height = 24;
			this.dgvTTD.Size = new System.Drawing.Size(967, 177);
			this.dgvTTD.TabIndex = 13;
			this.dgvTTD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTD_CellContentClick);
			// 
			// txtTenLop
			// 
			this.txtTenLop.Location = new System.Drawing.Point(400, 85);
			this.txtTenLop.Name = "txtTenLop";
			this.txtTenLop.ReadOnly = true;
			this.txtTenLop.Size = new System.Drawing.Size(174, 24);
			this.txtTenLop.TabIndex = 12;
			// 
			// txtMaLop
			// 
			this.txtMaLop.Location = new System.Drawing.Point(400, 37);
			this.txtMaLop.Name = "txtMaLop";
			this.txtMaLop.ReadOnly = true;
			this.txtMaLop.Size = new System.Drawing.Size(117, 24);
			this.txtMaLop.TabIndex = 11;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(125, 85);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.ReadOnly = true;
			this.txtHoTen.Size = new System.Drawing.Size(150, 24);
			this.txtHoTen.TabIndex = 10;
			// 
			// txtMaSv
			// 
			this.txtMaSv.Location = new System.Drawing.Point(125, 40);
			this.txtMaSv.Name = "txtMaSv";
			this.txtMaSv.ReadOnly = true;
			this.txtMaSv.Size = new System.Drawing.Size(108, 24);
			this.txtMaSv.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(300, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 18);
			this.label9.TabIndex = 8;
			this.label9.Text = "Tên lớp";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(300, 43);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 18);
			this.label8.TabIndex = 7;
			this.label8.Text = "Mã lớp";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(26, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Họ và tên";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mã sinh viên";
			// 
			// btnIn
			// 
			this.btnIn.Image = global::QuanLySinhVien.Properties.Resources.icon_printing_24px;
			this.btnIn.Location = new System.Drawing.Point(909, 684);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(114, 44);
			this.btnIn.TabIndex = 31;
			this.btnIn.Text = "In ra excel";
			this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::QuanLySinhVien.Properties.Resources.updated;
			this.btnCapNhat.Location = new System.Drawing.Point(562, 684);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(114, 44);
			this.btnCapNhat.TabIndex = 30;
			this.btnCapNhat.Text = " Cập nhật";
			this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.Image = global::QuanLySinhVien.Properties.Resources.cancel;
			this.btnHuy.Location = new System.Drawing.Point(735, 684);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(114, 44);
			this.btnHuy.TabIndex = 29;
			this.btnHuy.Text = "  Hủy";
			this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(373, 684);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(114, 44);
			this.btnXoa.TabIndex = 28;
			this.btnXoa.Text = "   Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icon_change_24px;
			this.btnSua.Location = new System.Drawing.Point(203, 684);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 44);
			this.btnSua.TabIndex = 27;
			this.btnSua.Text = "   Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px;
			this.btnThem.Location = new System.Drawing.Point(37, 684);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 26;
			this.btnThem.Text = "  Thêm ";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// frmQLDiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 740);
			this.Controls.Add(this.btnIn);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmQLDiem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QLDiem";
			this.Load += new System.EventHandler(this.QLDiem_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTTD)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbLopHP;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ComboBox cbbHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbHocKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTTD;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHK;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
	}
}