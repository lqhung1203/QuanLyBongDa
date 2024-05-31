namespace QLBongDa.Login
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.cboAnHien = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTakhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnHien
            // 
            this.cboAnHien.AutoSize = true;
            this.cboAnHien.Location = new System.Drawing.Point(409, 257);
            this.cboAnHien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAnHien.Name = "cboAnHien";
            this.cboAnHien.Size = new System.Drawing.Size(130, 20);
            this.cboAnHien.TabIndex = 13;
            this.cboAnHien.Text = "Hiển thị mật khẩu";
            this.cboAnHien.UseVisualStyleBackColor = true;
            this.cboAnHien.Click += new System.EventHandler(this.cboAnHien_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên tài khoản";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(368, 361);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(40, 18);
            this.lbError.TabIndex = 12;
            this.lbError.Text = "Lỗi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTakhoan
            // 
            this.txtTakhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakhoan.Location = new System.Drawing.Point(409, 149);
            this.txtTakhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTakhoan.Name = "txtTakhoan";
            this.txtTakhoan.Size = new System.Drawing.Size(277, 28);
            this.txtTakhoan.TabIndex = 7;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(409, 225);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(277, 28);
            this.txtMatkhau.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QLBongDa.Properties.Resources.logo_cho_giai_dau_bong_da_e1579131412435;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 471);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.Image")));
            this.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangnhap.Location = new System.Drawing.Point(445, 291);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(193, 43);
            this.btndangnhap.TabIndex = 11;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            this.btndangnhap.Enter += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(598, 425);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 34);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 471);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboAnHien);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTakhoan);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label1);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboAnHien;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTakhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}