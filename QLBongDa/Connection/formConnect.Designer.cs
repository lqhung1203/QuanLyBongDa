namespace QLBongDa.Connection
{
    partial class formConnect
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtTenDb = new System.Windows.Forms.TextBox();
            this.txtTenServer = new System.Windows.Forms.TextBox();
            this.rdoXacthucSQL = new System.Windows.Forms.RadioButton();
            this.rdoXacthucWins = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtMatkhau);
            this.panel1.Controls.Add(this.txtTaikhoan);
            this.panel1.Controls.Add(this.txtTenDb);
            this.panel1.Controls.Add(this.txtTenServer);
            this.panel1.Controls.Add(this.rdoXacthucSQL);
            this.panel1.Controls.Add(this.rdoXacthucWins);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 451);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(436, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(86, 340);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 45);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(192, 251);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(335, 27);
            this.txtMatkhau.TabIndex = 4;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(192, 203);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(335, 27);
            this.txtTaikhoan.TabIndex = 3;
            // 
            // txtTenDb
            // 
            this.txtTenDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDb.Location = new System.Drawing.Point(192, 88);
            this.txtTenDb.Name = "txtTenDb";
            this.txtTenDb.Size = new System.Drawing.Size(335, 27);
            this.txtTenDb.TabIndex = 2;
            // 
            // txtTenServer
            // 
            this.txtTenServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenServer.Location = new System.Drawing.Point(192, 46);
            this.txtTenServer.Name = "txtTenServer";
            this.txtTenServer.Size = new System.Drawing.Size(335, 27);
            this.txtTenServer.TabIndex = 1;
            // 
            // rdoXacthucSQL
            // 
            this.rdoXacthucSQL.AutoSize = true;
            this.rdoXacthucSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXacthucSQL.Location = new System.Drawing.Point(192, 161);
            this.rdoXacthucSQL.Name = "rdoXacthucSQL";
            this.rdoXacthucSQL.Size = new System.Drawing.Size(249, 24);
            this.rdoXacthucSQL.TabIndex = 18;
            this.rdoXacthucSQL.TabStop = true;
            this.rdoXacthucSQL.Text = "Chứng thực bằng SQL Server\r\n";
            this.rdoXacthucSQL.UseVisualStyleBackColor = true;
            this.rdoXacthucSQL.Click += new System.EventHandler(this.rdoXacthucSQL_CheckedChanged);
            // 
            // rdoXacthucWins
            // 
            this.rdoXacthucWins.AutoSize = true;
            this.rdoXacthucWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXacthucWins.Location = new System.Drawing.Point(192, 131);
            this.rdoXacthucWins.Name = "rdoXacthucWins";
            this.rdoXacthucWins.Size = new System.Drawing.Size(229, 24);
            this.rdoXacthucWins.TabIndex = 23;
            this.rdoXacthucWins.TabStop = true;
            this.rdoXacthucWins.Text = "Chứng thực bằng Windows";
            this.rdoXacthucWins.UseVisualStyleBackColor = true;
            this.rdoXacthucWins.Click += new System.EventHandler(this.rdoXacthucWins_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Server";
            // 
            // formConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(593, 451);
            this.Controls.Add(this.panel1);
            this.Name = "formConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formConnect";
            this.Load += new System.EventHandler(this.formConnect_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtTenDb;
        private System.Windows.Forms.TextBox txtTenServer;
        private System.Windows.Forms.RadioButton rdoXacthucSQL;
        private System.Windows.Forms.RadioButton rdoXacthucWins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}