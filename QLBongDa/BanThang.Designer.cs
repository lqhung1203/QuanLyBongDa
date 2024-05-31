namespace QLBongDa
{
    partial class BanThang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaDB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpThoiDiem = new System.Windows.Forms.DateTimePicker();
            this.txtmaBT = new System.Windows.Forms.TextBox();
            this.cbbMaCT = new System.Windows.Forms.ComboBox();
            this.cbbMaTD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoaiBT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtgvBanThang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanThang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.dtgvBanThang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 718);
            this.panel1.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 36);
            this.label6.TabIndex = 74;
            this.label6.Text = "BÀN THẮNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 430);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(453, 154);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(65, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 38);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(281, 38);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 38);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 67;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(65, 96);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 38);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaDB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpThoiDiem);
            this.groupBox1.Controls.Add(this.txtmaBT);
            this.groupBox1.Controls.Add(this.cbbMaCT);
            this.groupBox1.Controls.Add(this.cbbMaTD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbLoaiBT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(467, 335);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bàn Thắng";
            // 
            // cbbMaDB
            // 
            this.cbbMaDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaDB.FormattingEnabled = true;
            this.cbbMaDB.Items.AddRange(new object[] {
            "HLV Truong",
            "HLV The Luc"});
            this.cbbMaDB.Location = new System.Drawing.Point(185, 229);
            this.cbbMaDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaDB.Name = "cbbMaDB";
            this.cbbMaDB.Size = new System.Drawing.Size(211, 28);
            this.cbbMaDB.TabIndex = 75;
            this.cbbMaDB.SelectedIndexChanged += new System.EventHandler(this.cbbMaDB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Mã Đội Bóng";
            // 
            // dtpThoiDiem
            // 
            this.dtpThoiDiem.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiDiem.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpThoiDiem.Location = new System.Drawing.Point(185, 272);
            this.dtpThoiDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dtpThoiDiem.Name = "dtpThoiDiem";
            this.dtpThoiDiem.Size = new System.Drawing.Size(211, 26);
            this.dtpThoiDiem.TabIndex = 69;
            // 
            // txtmaBT
            // 
            this.txtmaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaBT.Location = new System.Drawing.Point(185, 52);
            this.txtmaBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaBT.Name = "txtmaBT";
            this.txtmaBT.Size = new System.Drawing.Size(211, 26);
            this.txtmaBT.TabIndex = 62;
            // 
            // cbbMaCT
            // 
            this.cbbMaCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCT.FormattingEnabled = true;
            this.cbbMaCT.Items.AddRange(new object[] {
            "HLV Truong",
            "HLV The Luc"});
            this.cbbMaCT.Location = new System.Drawing.Point(185, 140);
            this.cbbMaCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaCT.Name = "cbbMaCT";
            this.cbbMaCT.Size = new System.Drawing.Size(211, 28);
            this.cbbMaCT.TabIndex = 61;
            // 
            // cbbMaTD
            // 
            this.cbbMaTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaTD.FormattingEnabled = true;
            this.cbbMaTD.Items.AddRange(new object[] {
            "HLV Truong",
            "HLV The Luc"});
            this.cbbMaTD.Location = new System.Drawing.Point(185, 188);
            this.cbbMaTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaTD.Name = "cbbMaTD";
            this.cbbMaTD.Size = new System.Drawing.Size(211, 28);
            this.cbbMaTD.TabIndex = 71;
            this.cbbMaTD.SelectedIndexChanged += new System.EventHandler(this.cbbMaTD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Thời Điểm";
            // 
            // cbbLoaiBT
            // 
            this.cbbLoaiBT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiBT.FormattingEnabled = true;
            this.cbbLoaiBT.Items.AddRange(new object[] {
            "Đầu",
            "Đá phạt",
            "Phạt đền",
            "Phạt góc",
            "Sút",
            "Phản lưới",
            "Khác"});
            this.cbbLoaiBT.Location = new System.Drawing.Point(185, 95);
            this.cbbLoaiBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLoaiBT.Name = "cbbLoaiBT";
            this.cbbLoaiBT.Size = new System.Drawing.Size(211, 28);
            this.cbbLoaiBT.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Mã Cầu Thủ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã Bàn Thắng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Loại Bàn Thắng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Mã Trận Đấu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1023, 640);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 38);
            this.btnLamMoi.TabIndex = 66;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtgvBanThang
            // 
            this.dtgvBanThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBanThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBanThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanThang.Location = new System.Drawing.Point(559, 68);
            this.dtgvBanThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvBanThang.Name = "dtgvBanThang";
            this.dtgvBanThang.RowHeadersWidth = 51;
            this.dtgvBanThang.RowTemplate.Height = 24;
            this.dtgvBanThang.Size = new System.Drawing.Size(588, 516);
            this.dtgvBanThang.TabIndex = 60;
            this.dtgvBanThang.Click += new System.EventHandler(this.dtgvBanThang_Click);
            // 
            // BanThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 718);
            this.Controls.Add(this.panel1);
            this.Name = "BanThang";
            this.Text = "BanThang";
            this.Load += new System.EventHandler(this.BanThang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpThoiDiem;
        private System.Windows.Forms.TextBox txtmaBT;
        private System.Windows.Forms.ComboBox cbbMaCT;
        private System.Windows.Forms.ComboBox cbbMaTD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoaiBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dtgvBanThang;
        private System.Windows.Forms.ComboBox cbbMaDB;
        private System.Windows.Forms.Label label7;
    }
}