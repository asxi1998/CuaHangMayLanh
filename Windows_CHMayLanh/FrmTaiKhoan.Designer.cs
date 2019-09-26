namespace Windows_CHMayLanh
{
    partial class FrmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbTaiKhoan = new System.Windows.Forms.PictureBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.grbDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnHienThi2 = new System.Windows.Forms.Button();
            this.btnHienThi1 = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTaiKhoan)).BeginInit();
            this.grbDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Enabled = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(241, 164);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(235, 20);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(241, 202);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(235, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông Tin Tài Khoản";
            // 
            // pcbTaiKhoan
            // 
            this.pcbTaiKhoan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("pcbTaiKhoan.Image")));
            this.pcbTaiKhoan.InitialImage = null;
            this.pcbTaiKhoan.Location = new System.Drawing.Point(241, 74);
            this.pcbTaiKhoan.Name = "pcbTaiKhoan";
            this.pcbTaiKhoan.Size = new System.Drawing.Size(48, 51);
            this.pcbTaiKhoan.TabIndex = 16;
            this.pcbTaiKhoan.TabStop = false;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(494, 202);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(108, 23);
            this.btnDoiMatKhau.TabIndex = 17;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // grbDoiMatKhau
            // 
            this.grbDoiMatKhau.BackColor = System.Drawing.SystemColors.Highlight;
            this.grbDoiMatKhau.Controls.Add(this.btnHienThi2);
            this.grbDoiMatKhau.Controls.Add(this.btnHienThi1);
            this.grbDoiMatKhau.Controls.Add(this.btnHienThi);
            this.grbDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.grbDoiMatKhau.Controls.Add(this.label6);
            this.grbDoiMatKhau.Controls.Add(this.txtNhapLaiMK);
            this.grbDoiMatKhau.Controls.Add(this.label5);
            this.grbDoiMatKhau.Controls.Add(this.btnDoiMK);
            this.grbDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.grbDoiMatKhau.Controls.Add(this.label4);
            this.grbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDoiMatKhau.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.grbDoiMatKhau.Location = new System.Drawing.Point(623, 164);
            this.grbDoiMatKhau.Name = "grbDoiMatKhau";
            this.grbDoiMatKhau.Size = new System.Drawing.Size(530, 309);
            this.grbDoiMatKhau.TabIndex = 18;
            this.grbDoiMatKhau.TabStop = false;
            this.grbDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.grbDoiMatKhau.Visible = false;
            // 
            // btnHienThi2
            // 
            this.btnHienThi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi2.Location = new System.Drawing.Point(495, 198);
            this.btnHienThi2.Name = "btnHienThi2";
            this.btnHienThi2.Size = new System.Drawing.Size(26, 21);
            this.btnHienThi2.TabIndex = 27;
            this.btnHienThi2.Text = "*";
            this.btnHienThi2.UseVisualStyleBackColor = true;
            this.btnHienThi2.Click += new System.EventHandler(this.btnHienThi2_Click);
            // 
            // btnHienThi1
            // 
            this.btnHienThi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi1.Location = new System.Drawing.Point(495, 136);
            this.btnHienThi1.Name = "btnHienThi1";
            this.btnHienThi1.Size = new System.Drawing.Size(26, 21);
            this.btnHienThi1.TabIndex = 26;
            this.btnHienThi1.Text = "*";
            this.btnHienThi1.UseVisualStyleBackColor = true;
            this.btnHienThi1.Click += new System.EventHandler(this.btnHienThi1_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(495, 74);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(26, 21);
            this.btnHienThi.TabIndex = 25;
            this.btnHienThi.Text = "*";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(245, 74);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(245, 31);
            this.txtMatKhauCu.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(91, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mật Khẩu Cũ";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMK.Location = new System.Drawing.Point(245, 198);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.PasswordChar = '*';
            this.txtNhapLaiMK.Size = new System.Drawing.Size(245, 31);
            this.txtNhapLaiMK.TabIndex = 22;
            this.txtNhapLaiMK.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nhập Lại Mật Khẩu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDoiMK.Location = new System.Drawing.Point(245, 253);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(218, 45);
            this.btnDoiMK.TabIndex = 20;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(245, 136);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(245, 31);
            this.txtMatKhauMoi.TabIndex = 19;
            this.txtMatKhauMoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(82, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mật Khẩu Mới";
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 498);
            this.ControlBox = false;
            this.Controls.Add(this.grbDoiMatKhau);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.pcbTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTaiKhoan";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbTaiKhoan)).EndInit();
            this.grbDoiMatKhau.ResumeLayout(false);
            this.grbDoiMatKhau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbTaiKhoan;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.GroupBox grbDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHienThi2;
        private System.Windows.Forms.Button btnHienThi1;
        private System.Windows.Forms.Button btnHienThi;
    }
}