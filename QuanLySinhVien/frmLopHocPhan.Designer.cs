namespace QuanLySinhVien
{
    partial class frmLopHocPhan
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTiLe = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbbMaHK = new System.Windows.Forms.ComboBox();
			this.cbbMaGV = new System.Windows.Forms.ComboBox();
			this.cbbMHP = new System.Windows.Forms.ComboBox();
			this.txtDD = new System.Windows.Forms.TextBox();
			this.txtSS = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.txtMa = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnEX = new System.Windows.Forms.Button();
			this.btnRS = new System.Windows.Forms.Button();
			this.btnTK = new System.Windows.Forms.Button();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.txtTL = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvData
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.BackgroundColor = System.Drawing.Color.White;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Location = new System.Drawing.Point(14, 331);
			this.dgvData.Name = "dgvData";
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersWidth = 51;
			this.dgvData.RowTemplate.Height = 24;
			this.dgvData.Size = new System.Drawing.Size(986, 260);
			this.dgvData.TabIndex = 39;
			this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtTiLe);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cbbMaHK);
			this.groupBox1.Controls.Add(this.cbbMaGV);
			this.groupBox1.Controls.Add(this.cbbMHP);
			this.groupBox1.Controls.Add(this.txtDD);
			this.groupBox1.Controls.Add(this.txtSS);
			this.groupBox1.Controls.Add(this.txtTen);
			this.groupBox1.Controls.Add(this.txtMa);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(14, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(986, 308);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin lớp học phần";
			// 
			// txtTiLe
			// 
			this.txtTiLe.Location = new System.Drawing.Point(687, 32);
			this.txtTiLe.Margin = new System.Windows.Forms.Padding(4);
			this.txtTiLe.Name = "txtTiLe";
			this.txtTiLe.Size = new System.Drawing.Size(262, 24);
			this.txtTiLe.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(546, 42);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 18);
			this.label8.TabIndex = 26;
			this.label8.Text = "Tỉ lệ điểm";
			// 
			// cbbMaHK
			// 
			this.cbbMaHK.FormattingEnabled = true;
			this.cbbMaHK.Location = new System.Drawing.Point(687, 236);
			this.cbbMaHK.Margin = new System.Windows.Forms.Padding(4);
			this.cbbMaHK.Name = "cbbMaHK";
			this.cbbMaHK.Size = new System.Drawing.Size(262, 26);
			this.cbbMaHK.TabIndex = 24;
			// 
			// cbbMaGV
			// 
			this.cbbMaGV.FormattingEnabled = true;
			this.cbbMaGV.Location = new System.Drawing.Point(687, 165);
			this.cbbMaGV.Margin = new System.Windows.Forms.Padding(4);
			this.cbbMaGV.Name = "cbbMaGV";
			this.cbbMaGV.Size = new System.Drawing.Size(262, 26);
			this.cbbMaGV.TabIndex = 13;
			// 
			// cbbMHP
			// 
			this.cbbMHP.FormattingEnabled = true;
			this.cbbMHP.Location = new System.Drawing.Point(687, 100);
			this.cbbMHP.Margin = new System.Windows.Forms.Padding(4);
			this.cbbMHP.Name = "cbbMHP";
			this.cbbMHP.Size = new System.Drawing.Size(262, 26);
			this.cbbMHP.TabIndex = 12;
			// 
			// txtDD
			// 
			this.txtDD.Location = new System.Drawing.Point(148, 241);
			this.txtDD.Margin = new System.Windows.Forms.Padding(4);
			this.txtDD.Name = "txtDD";
			this.txtDD.Size = new System.Drawing.Size(262, 24);
			this.txtDD.TabIndex = 10;
			// 
			// txtSS
			// 
			this.txtSS.Location = new System.Drawing.Point(148, 168);
			this.txtSS.Margin = new System.Windows.Forms.Padding(4);
			this.txtSS.Name = "txtSS";
			this.txtSS.Size = new System.Drawing.Size(262, 24);
			this.txtSS.TabIndex = 9;
			// 
			// txtTen
			// 
			this.txtTen.Location = new System.Drawing.Point(148, 100);
			this.txtTen.Margin = new System.Windows.Forms.Padding(4);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(262, 24);
			this.txtTen.TabIndex = 8;
			// 
			// txtMa
			// 
			this.txtMa.Location = new System.Drawing.Point(148, 32);
			this.txtMa.Margin = new System.Windows.Forms.Padding(4);
			this.txtMa.Name = "txtMa";
			this.txtMa.Size = new System.Drawing.Size(262, 24);
			this.txtMa.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(548, 245);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Mã HK";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(546, 178);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mã GV";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(546, 109);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mã Học Phần";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 245);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa Điểm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 178);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sĩ Số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 109);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên lớp";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã Lớp";
			// 
			// btnEX
			// 
			this.btnEX.Image = global::QuanLySinhVien.Properties.Resources.icon_printing_24px;
			this.btnEX.Location = new System.Drawing.Point(851, 619);
			this.btnEX.Margin = new System.Windows.Forms.Padding(4);
			this.btnEX.Name = "btnEX";
			this.btnEX.Size = new System.Drawing.Size(114, 44);
			this.btnEX.TabIndex = 37;
			this.btnEX.Text = " Xuất Excel";
			this.btnEX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEX.UseVisualStyleBackColor = true;
			this.btnEX.Click += new System.EventHandler(this.btnEX_Click);
			// 
			// btnRS
			// 
			this.btnRS.Image = global::QuanLySinhVien.Properties.Resources.reset;
			this.btnRS.Location = new System.Drawing.Point(660, 619);
			this.btnRS.Margin = new System.Windows.Forms.Padding(4);
			this.btnRS.Name = "btnRS";
			this.btnRS.Size = new System.Drawing.Size(114, 44);
			this.btnRS.TabIndex = 36;
			this.btnRS.Text = " Làm mới";
			this.btnRS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRS.UseVisualStyleBackColor = true;
			this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
			// 
			// btnTK
			// 
			this.btnTK.Image = global::QuanLySinhVien.Properties.Resources.icon_search_24px;
			this.btnTK.Location = new System.Drawing.Point(381, 685);
			this.btnTK.Margin = new System.Windows.Forms.Padding(4);
			this.btnTK.Name = "btnTK";
			this.btnTK.Size = new System.Drawing.Size(114, 44);
			this.btnTK.TabIndex = 32;
			this.btnTK.Text = " Tìm Kiếm";
			this.btnTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTK.UseVisualStyleBackColor = true;
			this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(98, 695);
			this.txtTK.Margin = new System.Windows.Forms.Padding(4);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(262, 24);
			this.txtTK.TabIndex = 31;
			// 
			// btnThem
			// 
			this.btnThem.Image = global::QuanLySinhVien.Properties.Resources.icon_add_24px;
			this.btnThem.Location = new System.Drawing.Point(63, 619);
			this.btnThem.Margin = new System.Windows.Forms.Padding(4);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(114, 44);
			this.btnThem.TabIndex = 33;
			this.btnThem.Text = "  Thêm";
			this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::QuanLySinhVien.Properties.Resources.icon_delete_24px;
			this.btnXoa.Location = new System.Drawing.Point(460, 619);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(114, 44);
			this.btnXoa.TabIndex = 35;
			this.btnXoa.Text = "   Xóa";
			this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// txtTL
			// 
			this.txtTL.AutoSize = true;
			this.txtTL.Location = new System.Drawing.Point(28, 698);
			this.txtTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtTL.Name = "txtTL";
			this.txtTL.Size = new System.Drawing.Size(58, 18);
			this.txtTL.TabIndex = 30;
			this.txtTL.Text = "Mã Lớp";
			// 
			// btnSua
			// 
			this.btnSua.Image = global::QuanLySinhVien.Properties.Resources.icon_change_24px;
			this.btnSua.Location = new System.Drawing.Point(259, 619);
			this.btnSua.Margin = new System.Windows.Forms.Padding(4);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 44);
			this.btnSua.TabIndex = 34;
			this.btnSua.Text = "   Sửa";
			this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// frmLopHocPhan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 735);
			this.Controls.Add(this.dgvData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnEX);
			this.Controls.Add(this.btnRS);
			this.Controls.Add(this.btnTK);
			this.Controls.Add(this.txtTK);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.txtTL);
			this.Controls.Add(this.btnSua);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmLopHocPhan";
			this.Text = "frmLopHocPhan";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMaHK;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.ComboBox cbbMHP;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEX;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label txtTL;
        private System.Windows.Forms.Button btnSua;
    }
}