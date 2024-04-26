namespace QuanLySinhVien
{
    partial class frmHocPhan
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
			this.txtSoTiet = new System.Windows.Forms.TextBox();
			this.txtSoTC = new System.Windows.Forms.TextBox();
			this.txtTenHP = new System.Windows.Forms.TextBox();
			this.txtMaHP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvHocPhan = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnHuy = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSoTiet);
			this.groupBox1.Controls.Add(this.txtSoTC);
			this.groupBox1.Controls.Add(this.txtTenHP);
			this.groupBox1.Controls.Add(this.txtMaHP);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(53, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(990, 182);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin học phần";
			// 
			// txtSoTiet
			// 
			this.txtSoTiet.Location = new System.Drawing.Point(619, 104);
			this.txtSoTiet.Name = "txtSoTiet";
			this.txtSoTiet.Size = new System.Drawing.Size(143, 24);
			this.txtSoTiet.TabIndex = 7;
			// 
			// txtSoTC
			// 
			this.txtSoTC.Location = new System.Drawing.Point(619, 37);
			this.txtSoTC.Name = "txtSoTC";
			this.txtSoTC.Size = new System.Drawing.Size(143, 24);
			this.txtSoTC.TabIndex = 6;
			// 
			// txtTenHP
			// 
			this.txtTenHP.Location = new System.Drawing.Point(178, 107);
			this.txtTenHP.Name = "txtTenHP";
			this.txtTenHP.Size = new System.Drawing.Size(243, 24);
			this.txtTenHP.TabIndex = 5;
			// 
			// txtMaHP
			// 
			this.txtMaHP.Location = new System.Drawing.Point(178, 37);
			this.txtMaHP.Name = "txtMaHP";
			this.txtMaHP.Size = new System.Drawing.Size(243, 24);
			this.txtMaHP.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(493, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số tiết";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(493, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Số tín chỉ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên học phần:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã học phần:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvHocPhan);
			this.groupBox2.Location = new System.Drawing.Point(53, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(990, 251);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách học phần";
			// 
			// dgvHocPhan
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvHocPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHocPhan.BackgroundColor = System.Drawing.Color.White;
			this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHocPhan.Location = new System.Drawing.Point(11, 26);
			this.dgvHocPhan.Name = "dgvHocPhan";
			this.dgvHocPhan.ReadOnly = true;
			this.dgvHocPhan.RowHeadersWidth = 51;
			this.dgvHocPhan.RowTemplate.Height = 24;
			this.dgvHocPhan.Size = new System.Drawing.Size(967, 219);
			this.dgvHocPhan.TabIndex = 0;
			this.dgvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellClick);
			this.dgvHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPhan_CellContentClick);
			// 
			// btnThem
			// 
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px;
			this.btnThem.Location = new System.Drawing.Point(53, 520);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = " Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icon_change_24px;
			this.btnSua.Location = new System.Drawing.Point(267, 522);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 44);
			this.btnSua.TabIndex = 5;
			this.btnSua.Text = "  Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(492, 522);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(114, 44);
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "   Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::QuanLySinhVien.Properties.Resources.updated;
			this.btnCapNhat.Location = new System.Drawing.Point(716, 522);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(114, 44);
			this.btnCapNhat.TabIndex = 7;
			this.btnCapNhat.Text = " Cập nhật";
			this.btnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(53, 609);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(243, 24);
			this.txtTK.TabIndex = 8;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search_24px;
			this.btnTimKiem.Location = new System.Drawing.Point(326, 599);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(114, 44);
			this.btnTimKiem.TabIndex = 9;
			this.btnTimKiem.Text = " Tìm kiếm";
			this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.button5_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(50, 636);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 18);
			this.label7.TabIndex = 10;
			this.label7.Text = "Tìm kiếm theo tên";
			// 
			// btnHuy
			// 
			this.btnHuy.Image = global::QuanLySinhVien.Properties.Resources.cancel;
			this.btnHuy.Location = new System.Drawing.Point(920, 522);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(114, 44);
			this.btnHuy.TabIndex = 11;
			this.btnHuy.Text = "   Hủy";
			this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// frmHocPhan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1087, 667);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmHocPhan";
			this.Text = "frmHocPhan";
			this.Load += new System.EventHandler(this.frmHocPhan_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.Button btnHuy;
    }
}