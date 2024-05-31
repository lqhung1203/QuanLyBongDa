namespace QLBongDa
{
    partial class CauThu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoAo = new System.Windows.Forms.TextBox();
            this.txtmaCauThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCauThu = new System.Windows.Forms.TextBox();
            this.cbbMaDB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbViTri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgvCauThu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.dtgvCauThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 686);
            this.panel1.TabIndex = 72;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 479);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(453, 154);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(65, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 38);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(281, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 38);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(65, 96);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 38);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(281, 96);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(111, 38);
            this.btnLamMoi.TabIndex = 66;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 36);
            this.label6.TabIndex = 71;
            this.label6.Text = "CẦU THỦ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoAo);
            this.groupBox1.Controls.Add(this.txtmaCauThu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenCauThu);
            this.groupBox1.Controls.Add(this.cbbMaDB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbViTri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(467, 335);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Các Cầu Thủ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã Cầu Thủ";
            // 
            // txtSoAo
            // 
            this.txtSoAo.Location = new System.Drawing.Point(325, 190);
            this.txtSoAo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoAo.Name = "txtSoAo";
            this.txtSoAo.Size = new System.Drawing.Size(65, 30);
            this.txtSoAo.TabIndex = 69;
            // 
            // txtmaCauThu
            // 
            this.txtmaCauThu.Location = new System.Drawing.Point(163, 82);
            this.txtmaCauThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaCauThu.Name = "txtmaCauThu";
            this.txtmaCauThu.Size = new System.Drawing.Size(228, 30);
            this.txtmaCauThu.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 68;
            this.label5.Text = "Số Áo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tên Cầu Thủ";
            // 
            // txtTenCauThu
            // 
            this.txtTenCauThu.Location = new System.Drawing.Point(163, 124);
            this.txtTenCauThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCauThu.Name = "txtTenCauThu";
            this.txtTenCauThu.Size = new System.Drawing.Size(228, 30);
            this.txtTenCauThu.TabIndex = 56;
            // 
            // cbbMaDB
            // 
            this.cbbMaDB.FormattingEnabled = true;
            this.cbbMaDB.Items.AddRange(new object[] {
            "DB01",
            "DB02",
            "DB03"});
            this.cbbMaDB.Location = new System.Drawing.Point(163, 241);
            this.cbbMaDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaDB.Name = "cbbMaDB";
            this.cbbMaDB.Size = new System.Drawing.Size(228, 33);
            this.cbbMaDB.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Vị Trí";
            // 
            // cbbViTri
            // 
            this.cbbViTri.FormattingEnabled = true;
            this.cbbViTri.Items.AddRange(new object[] {
            "GK",
            "CB",
            "LB",
            "RB",
            "CDM",
            "CM",
            "CAM",
            "CF",
            "RW",
            "LW",
            "ST"});
            this.cbbViTri.Location = new System.Drawing.Point(163, 187);
            this.cbbViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbViTri.Name = "cbbViTri";
            this.cbbViTri.Size = new System.Drawing.Size(69, 33);
            this.cbbViTri.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên Đội Bóng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(999, 622);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 38);
            this.btnThoat.TabIndex = 67;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgvCauThu
            // 
            this.dtgvCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCauThu.Location = new System.Drawing.Point(542, 89);
            this.dtgvCauThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCauThu.Name = "dtgvCauThu";
            this.dtgvCauThu.RowHeadersWidth = 51;
            this.dtgvCauThu.RowTemplate.Height = 24;
            this.dtgvCauThu.Size = new System.Drawing.Size(583, 490);
            this.dtgvCauThu.TabIndex = 59;
            this.dtgvCauThu.Click += new System.EventHandler(this.dtgvCauThu_Click);
            // 
            // CauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 686);
            this.Controls.Add(this.panel1);
            this.Name = "CauThu";
            this.Text = "CauThu";
            this.Load += new System.EventHandler(this.CauThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCauThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoAo;
        private System.Windows.Forms.TextBox txtmaCauThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCauThu;
        private System.Windows.Forms.ComboBox cbbMaDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbViTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgvCauThu;
    }
}