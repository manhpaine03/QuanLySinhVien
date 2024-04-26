namespace QuanLySinhVien
{
    partial class frmQLKhoa
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvKhoa = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnResert = new System.Windows.Forms.Button();
			this.txtTenKhoa = new System.Windows.Forms.TextBox();
			this.txtMaKhoa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvKhoa);
			this.groupBox2.Location = new System.Drawing.Point(501, 30);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(512, 588);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dữ liệu";
			// 
			// dgvKhoa
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvKhoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKhoa.BackgroundColor = System.Drawing.Color.White;
			this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvKhoa.Location = new System.Drawing.Point(3, 20);
			this.dgvKhoa.Name = "dgvKhoa";
			this.dgvKhoa.ReadOnly = true;
			this.dgvKhoa.RowHeadersWidth = 51;
			this.dgvKhoa.RowTemplate.Height = 24;
			this.dgvKhoa.Size = new System.Drawing.Size(506, 565);
			this.dgvKhoa.TabIndex = 0;
			this.dgvKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSoDT);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnResert);
			this.groupBox1.Controls.Add(this.txtTenKhoa);
			this.groupBox1.Controls.Add(this.txtMaKhoa);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(38, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 585);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin Khoa";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(164, 136);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(227, 24);
			this.txtSoDT.TabIndex = 7;
			this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "Số điện thoại:";
			// 
			// btnResert
			// 
			this.btnResert.Image = global::QuanLySinhVien.Properties.Resources.reset;
			this.btnResert.Location = new System.Drawing.Point(67, 182);
			this.btnResert.Name = "btnResert";
			this.btnResert.Size = new System.Drawing.Size(114, 44);
			this.btnResert.TabIndex = 5;
			this.btnResert.Text = "  Resert";
			this.btnResert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnResert.UseVisualStyleBackColor = true;
			this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
			// 
			// txtTenKhoa
			// 
			this.txtTenKhoa.Location = new System.Drawing.Point(164, 90);
			this.txtTenKhoa.Name = "txtTenKhoa";
			this.txtTenKhoa.Size = new System.Drawing.Size(227, 24);
			this.txtTenKhoa.TabIndex = 4;
			// 
			// txtMaKhoa
			// 
			this.txtMaKhoa.Location = new System.Drawing.Point(164, 46);
			this.txtMaKhoa.Name = "txtMaKhoa";
			this.txtMaKhoa.Size = new System.Drawing.Size(227, 24);
			this.txtMaKhoa.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên Khoa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã Khoa:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnTimKiem);
			this.groupBox3.Controls.Add(this.txtTK);
			this.groupBox3.Controls.Add(this.btnXoa);
			this.groupBox3.Controls.Add(this.btnSua);
			this.groupBox3.Controls.Add(this.btnThem);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Location = new System.Drawing.Point(6, 250);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(445, 222);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thao tác";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::QuanLySinhVien.Properties.Resources.icon_search_24px;
			this.btnTimKiem.Location = new System.Drawing.Point(303, 26);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(114, 44);
			this.btnTimKiem.TabIndex = 9;
			this.btnTimKiem.Text = " Tìm kiếm";
			this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(34, 36);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(224, 24);
			this.txtTK.TabIndex = 8;
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(169, 139);
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
			this.btnSua.Location = new System.Drawing.Point(325, 139);
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
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px1;
			this.btnThem.Location = new System.Drawing.Point(6, 139);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "  Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(164, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tìm kiếm theo mã khoa";
			// 
			// frmQLKhoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 647);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmQLKhoa";
			this.Text = "frmQLKhoa";
			this.Load += new System.EventHandler(this.frmKhoa_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
    }
}