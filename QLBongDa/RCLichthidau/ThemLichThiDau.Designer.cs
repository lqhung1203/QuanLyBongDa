namespace QLBongDa.RCLichthidau
{
    partial class ThemLichThiDau
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
            this.panel1_body = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaTT = new System.Windows.Forms.ComboBox();
            this.cboMaSVD = new System.Windows.Forms.ComboBox();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.cboDoi2 = new System.Windows.Forms.ComboBox();
            this.cboDoi1 = new System.Windows.Forms.ComboBox();
            this.dtfGioTD = new System.Windows.Forms.DateTimePicker();
            this.dtfNgayTD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTTLichThiDau = new System.Windows.Forms.DataGridView();
            this.panel1_body.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTTLichThiDau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_body
            // 
            this.panel1_body.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_body.Controls.Add(this.groupBox2);
            this.panel1_body.Controls.Add(this.btnXoaCapNhat);
            this.panel1_body.Controls.Add(this.groupBox1);
            this.panel1_body.Controls.Add(this.dtgTTLichThiDau);
            this.panel1_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_body.Location = new System.Drawing.Point(0, 0);
            this.panel1_body.Name = "panel1_body";
            this.panel1_body.Size = new System.Drawing.Size(1147, 673);
            this.panel1_body.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1099, 75);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(134, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 41);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Tạo trận đấu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(447, 24);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(139, 41);
            this.btnLammoi.TabIndex = 8;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(823, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 41);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaCapNhat
            // 
            this.btnXoaCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCapNhat.Location = new System.Drawing.Point(44, 629);
            this.btnXoaCapNhat.Name = "btnXoaCapNhat";
            this.btnXoaCapNhat.Size = new System.Drawing.Size(139, 41);
            this.btnXoaCapNhat.TabIndex = 12;
            this.btnXoaCapNhat.Text = "Cập Nhật";
            this.btnXoaCapNhat.UseVisualStyleBackColor = true;
            this.btnXoaCapNhat.Click += new System.EventHandler(this.btnXoaCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaTT);
            this.groupBox1.Controls.Add(this.cboMaSVD);
            this.groupBox1.Controls.Add(this.txtMaTD);
            this.groupBox1.Controls.Add(this.cboDoi2);
            this.groupBox1.Controls.Add(this.cboDoi1);
            this.groupBox1.Controls.Add(this.dtfGioTD);
            this.groupBox1.Controls.Add(this.dtfNgayTD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 279);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Lịch Thi Đấu";
            // 
            // cboMaTT
            // 
            this.cboMaTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTT.FormattingEnabled = true;
            this.cboMaTT.Location = new System.Drawing.Point(763, 94);
            this.cboMaTT.Name = "cboMaTT";
            this.cboMaTT.Size = new System.Drawing.Size(274, 28);
            this.cboMaTT.TabIndex = 14;
            // 
            // cboMaSVD
            // 
            this.cboMaSVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSVD.FormattingEnabled = true;
            this.cboMaSVD.Location = new System.Drawing.Point(189, 93);
            this.cboMaSVD.Name = "cboMaSVD";
            this.cboMaSVD.Size = new System.Drawing.Size(273, 28);
            this.cboMaSVD.TabIndex = 14;
            // 
            // txtMaTD
            // 
            this.txtMaTD.Location = new System.Drawing.Point(189, 38);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(273, 27);
            this.txtMaTD.TabIndex = 13;
            // 
            // cboDoi2
            // 
            this.cboDoi2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoi2.FormattingEnabled = true;
            this.cboDoi2.Location = new System.Drawing.Point(763, 160);
            this.cboDoi2.Name = "cboDoi2";
            this.cboDoi2.Size = new System.Drawing.Size(274, 28);
            this.cboDoi2.TabIndex = 11;
            // 
            // cboDoi1
            // 
            this.cboDoi1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoi1.FormattingEnabled = true;
            this.cboDoi1.Location = new System.Drawing.Point(189, 160);
            this.cboDoi1.Name = "cboDoi1";
            this.cboDoi1.Size = new System.Drawing.Size(273, 28);
            this.cboDoi1.TabIndex = 12;
            // 
            // dtfGioTD
            // 
            this.dtfGioTD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtfGioTD.Location = new System.Drawing.Point(189, 217);
            this.dtfGioTD.Name = "dtfGioTD";
            this.dtfGioTD.Size = new System.Drawing.Size(233, 27);
            this.dtfGioTD.TabIndex = 9;
            // 
            // dtfNgayTD
            // 
            this.dtfNgayTD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfNgayTD.Location = new System.Drawing.Point(763, 219);
            this.dtfNgayTD.Name = "dtfNgayTD";
            this.dtfNgayTD.Size = new System.Drawing.Size(233, 27);
            this.dtfNgayTD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ thi đấu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày thi đấu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đội 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sân Vận Động";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trọng Tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đội 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã trận đấu";
            // 
            // dtgTTLichThiDau
            // 
            this.dtgTTLichThiDau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTTLichThiDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTTLichThiDau.Location = new System.Drawing.Point(36, 408);
            this.dtgTTLichThiDau.Name = "dtgTTLichThiDau";
            this.dtgTTLichThiDau.RowHeadersWidth = 51;
            this.dtgTTLichThiDau.RowTemplate.Height = 24;
            this.dtgTTLichThiDau.Size = new System.Drawing.Size(1099, 212);
            this.dtgTTLichThiDau.TabIndex = 7;
            this.dtgTTLichThiDau.Click += new System.EventHandler(this.dtgTTLichThiDau_Click);
            // 
            // ThemLichThiDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 673);
            this.Controls.Add(this.panel1_body);
            this.Name = "ThemLichThiDau";
            this.Text = "ThemLichThiDau";
            this.Load += new System.EventHandler(this.ThemLichThiDau_Load);
            this.panel1_body.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTTLichThiDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_body;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaTT;
        private System.Windows.Forms.ComboBox cboMaSVD;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.ComboBox cboDoi2;
        private System.Windows.Forms.ComboBox cboDoi1;
        private System.Windows.Forms.DateTimePicker dtfGioTD;
        private System.Windows.Forms.DateTimePicker dtfNgayTD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgTTLichThiDau;
        private System.Windows.Forms.Button btnXoaCapNhat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}