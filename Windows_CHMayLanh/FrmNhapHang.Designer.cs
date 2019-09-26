namespace Windows_CHMayLanh
{
    partial class FrmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapHang));
            this.pcbNhapHang = new System.Windows.Forms.PictureBox();
            this.btnThemDonHang = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNhapHang = new System.Windows.Forms.GroupBox();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaDonHang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.MACTHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNhapHang)).BeginInit();
            this.grbNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbNhapHang
            // 
            this.pcbNhapHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("pcbNhapHang.Image")));
            this.pcbNhapHang.InitialImage = null;
            this.pcbNhapHang.Location = new System.Drawing.Point(166, 12);
            this.pcbNhapHang.Name = "pcbNhapHang";
            this.pcbNhapHang.Size = new System.Drawing.Size(54, 50);
            this.pcbNhapHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNhapHang.TabIndex = 7;
            this.pcbNhapHang.TabStop = false;
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDonHang.Location = new System.Drawing.Point(170, 190);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(146, 28);
            this.btnThemDonHang.TabIndex = 38;
            this.btnThemDonHang.Text = "Thêm Đơn Hàng";
            this.btnThemDonHang.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(170, 164);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(219, 20);
            this.txtSoLuong.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số Lượng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(550, 129);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(219, 20);
            this.txtTenHang.TabIndex = 35;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(170, 90);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(219, 20);
            this.txtMaNCC.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nhập Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // grbNhapHang
            // 
            this.grbNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhapHang.AutoSize = true;
            this.grbNhapHang.Controls.Add(this.dgvNhapHang);
            this.grbNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapHang.Location = new System.Drawing.Point(38, 224);
            this.grbNhapHang.Name = "grbNhapHang";
            this.grbNhapHang.Size = new System.Drawing.Size(861, 325);
            this.grbNhapHang.TabIndex = 40;
            this.grbNhapHang.TabStop = false;
            this.grbNhapHang.Text = "Hàng Nhập";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACTHDN,
            this.MAHDN,
            this.MAHANGHOA,
            this.SOLUONG,
            this.DONGIA});
            this.dgvNhapHang.Location = new System.Drawing.Point(7, 29);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.Size = new System.Drawing.Size(848, 287);
            this.dgvNhapHang.TabIndex = 0;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(550, 164);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(219, 20);
            this.txtDonGia.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Đơn Giá";
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(170, 127);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(219, 20);
            this.txtNamSX.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Năm SX";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(550, 90);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(219, 20);
            this.txtMaHang.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Mã Hàng Hóa";
            // 
            // btnXoaDonHang
            // 
            this.btnXoaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDonHang.Location = new System.Drawing.Point(331, 190);
            this.btnXoaDonHang.Name = "btnXoaDonHang";
            this.btnXoaDonHang.Size = new System.Drawing.Size(58, 28);
            this.btnXoaDonHang.TabIndex = 47;
            this.btnXoaDonHang.Text = "Xóa";
            this.btnXoaDonHang.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(782, 190);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 28);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // MACTHDN
            // 
            this.MACTHDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACTHDN.DataPropertyName = "MACTHDN";
            this.MACTHDN.HeaderText = "Mã Chi Tiết HD";
            this.MACTHDN.Name = "MACTHDN";
            // 
            // MAHDN
            // 
            this.MAHDN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHDN.DataPropertyName = "MAHDN";
            this.MAHDN.HeaderText = "Mã Hóa Đơn Nhập";
            this.MAHDN.Name = "MAHDN";
            // 
            // MAHANGHOA
            // 
            this.MAHANGHOA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHANGHOA.DataPropertyName = "MAHANGHOA";
            this.MAHANGHOA.HeaderText = "Mã Hàng Hóa";
            this.MAHANGHOA.Name = "MAHANGHOA";
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.ControlBox = false;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaDonHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNamSX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbNhapHang);
            this.Controls.Add(this.btnThemDonHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbNhapHang);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbNhapHang)).EndInit();
            this.grbNhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbNhapHang;
        private System.Windows.Forms.Button btnThemDonHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbNhapHang;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaDonHang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
    }
}