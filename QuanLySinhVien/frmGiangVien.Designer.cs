namespace QuanLySinhVien
{
    partial class frmGiangVien
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
			this.btnTK = new System.Windows.Forms.Button();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAnh = new System.Windows.Forms.Button();
			this.txtCM = new System.Windows.Forms.TextBox();
			this.txtEMAIL = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.picAnh = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblMa = new System.Windows.Forms.Label();
			this.btnIN = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnRS = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTK
			// 
			this.btnTK.Location = new System.Drawing.Point(365, 628);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(114, 44);
			this.btnTK.TabIndex = 53;
			this.btnTK.Text = "Tìm Kiếm";
			this.btnTK.UseVisualStyleBackColor = true;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(131, 638);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(208, 24);
			this.txtTK.TabIndex = 52;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 641);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 51;
			this.label1.Text = "Mã GV";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvData);
			this.groupBox2.Location = new System.Drawing.Point(53, 321);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1007, 215);
			this.groupBox2.TabIndex = 50;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách giảng viên";
			// 
			// dgvData
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.BackgroundColor = System.Drawing.Color.White;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Location = new System.Drawing.Point(7, 33);
			this.dgvData.Margin = new System.Windows.Forms.Padding(4);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.Size = new System.Drawing.Size(993, 164);
			this.dgvData.TabIndex = 36;
			this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnAnh);
			this.groupBox1.Controls.Add(this.txtCM);
			this.groupBox1.Controls.Add(this.txtEMAIL);
			this.groupBox1.Controls.Add(this.txtSDT);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Controls.Add(this.txtMa);
			this.groupBox1.Controls.Add(this.picAnh);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblMa);
			this.groupBox1.Location = new System.Drawing.Point(53, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1007, 284);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin giảng viên";
			// 
			// btnAnh
			// 
			this.btnAnh.Image = global::QuanLySinhVien.Properties.Resources.image_;
			this.btnAnh.Location = new System.Drawing.Point(568, 27);
			this.btnAnh.Margin = new System.Windows.Forms.Padding(4);
			this.btnAnh.Name = "btnAnh";
			this.btnAnh.Size = new System.Drawing.Size(114, 44);
			this.btnAnh.TabIndex = 37;
			this.btnAnh.Text = "   Ảnh";
			this.btnAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAnh.UseVisualStyleBackColor = true;
			this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
			// 
			// txtCM
			// 
			this.txtCM.Location = new System.Drawing.Point(180, 225);
			this.txtCM.Margin = new System.Windows.Forms.Padding(4);
			this.txtCM.Name = "txtCM";
			this.txtCM.Size = new System.Drawing.Size(230, 24);
			this.txtCM.TabIndex = 35;
			// 
			// txtEMAIL
			// 
			this.txtEMAIL.Location = new System.Drawing.Point(180, 176);
			this.txtEMAIL.Margin = new System.Windows.Forms.Padding(4);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(230, 24);
			this.txtEMAIL.TabIndex = 34;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(180, 127);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(230, 24);
			this.txtSDT.TabIndex = 33;
			this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(180, 80);
			this.txtTen.Margin = new System.Windows.Forms.Padding(4);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(230, 24);
			this.txtTen.TabIndex = 32;
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(180, 25);
			this.txtMa.Margin = new System.Windows.Forms.Padding(4);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(230, 24);
			this.txtMa.TabIndex = 31;
			// 
			// picAnh
			// 
			this.picAnh.Location = new System.Drawing.Point(713, 25);
			this.picAnh.Margin = new System.Windows.Forms.Padding(4);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(181, 161);
			this.picAnh.TabIndex = 25;
			this.picAnh.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 235);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 18);
			this.label5.TabIndex = 24;
			this.label5.Text = "Chuyên môn ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 184);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 18);
			this.label4.TabIndex = 23;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 136);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 18);
			this.label3.TabIndex = 22;
			this.label3.Text = "SĐT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(68, 84);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tên GV";
			// 
			// lblMa
			// 
			this.lblMa.AutoSize = true;
			this.lblMa.Location = new System.Drawing.Point(68, 34);
			this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMa.Name = "lblMa";
			this.lblMa.Size = new System.Drawing.Size(54, 18);
			this.lblMa.TabIndex = 20;
			this.lblMa.Text = "Mã GV";
			// 
			// btnIN
			// 
			this.btnIN.Image = global::QuanLySinhVien.Properties.Resources.icon_printing_24px;
			this.btnIN.Location = new System.Drawing.Point(936, 557);
			this.btnIN.Margin = new System.Windows.Forms.Padding(4);
			this.btnIN.Name = "btnIN";
			this.btnIN.Size = new System.Drawing.Size(114, 44);
			this.btnIN.TabIndex = 48;
			this.btnIN.Text = "    IN";
			this.btnIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIN.UseVisualStyleBackColor = true;
			this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
			// 
			// btnThem
			// 
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px;
			this.btnThem.Location = new System.Drawing.Point(53, 557);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 47;
			this.btnThem.Text = "   Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnRS
			// 
			this.btnRS.Image = global::QuanLySinhVien.Properties.Resources.reset;
			this.btnRS.Location = new System.Drawing.Point(727, 557);
			this.btnRS.Margin = new System.Windows.Forms.Padding(4);
			this.btnRS.Name = "btnRS";
			this.btnRS.Size = new System.Drawing.Size(114, 44);
			this.btnRS.TabIndex = 46;
			this.btnRS.Text = "  Reset";
			this.btnRS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRS.UseVisualStyleBackColor = true;
			this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(486, 557);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(114, 44);
			this.btnXoa.TabIndex = 45;
			this.btnXoa.Text = "   Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icon_change_24px;
			this.btnSua.Location = new System.Drawing.Point(252, 557);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 44);
			this.btnSua.TabIndex = 44;
			this.btnSua.Text = "   Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// frmGiangVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1111, 708);
			this.Controls.Add(this.btnTK);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnIN);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnRS);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmGiangVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmGiangVien";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}