namespace Windows_CHMayLanh
{
    partial class FrmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            this.label1 = new System.Windows.Forms.Label();
            this.pcbBanHang = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.grbChonHang = new System.Windows.Forms.GroupBox();
            this.dgvChonMatHang = new System.Windows.Forms.DataGridView();
            this.MACTHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemDonHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnXoaDonHang = new System.Windows.Forms.Button();
            this.cboTenHangHoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanHang)).BeginInit();
            this.grbChonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // pcbBanHang
            // 
            this.pcbBanHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbBanHang.Image = ((System.Drawing.Image)(resources.GetObject("pcbBanHang.Image")));
            this.pcbBanHang.ImageLocation = "";
            this.pcbBanHang.InitialImage = null;
            this.pcbBanHang.Location = new System.Drawing.Point(181, 12);
            this.pcbBanHang.Name = "pcbBanHang";
            this.pcbBanHang.Size = new System.Drawing.Size(50, 50);
            this.pcbBanHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBanHang.TabIndex = 8;
            this.pcbBanHang.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bán Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(179, 90);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(219, 20);
            this.txtTenKhachHang.TabIndex = 23;
            // 
            // grbChonHang
            // 
            this.grbChonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChonHang.AutoSize = true;
            this.grbChonHang.Controls.Add(this.dgvChonMatHang);
            this.grbChonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChonHang.Location = new System.Drawing.Point(47, 242);
            this.grbChonHang.Name = "grbChonHang";
            this.grbChonHang.Size = new System.Drawing.Size(954, 307);
            this.grbChonHang.TabIndex = 25;
            this.grbChonHang.TabStop = false;
            this.grbChonHang.Text = "Mặt Hàng Đã Chọn";
            // 
            // dgvChonMatHang
            // 
            this.dgvChonMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChonMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACTHDX,
            this.MAHDX,
            this.MAHANGHOA,
            this.TENHANGHOA,
            this.SOLUONG,
            this.DONGIA});
            this.dgvChonMatHang.Location = new System.Drawing.Point(7, 29);
            this.dgvChonMatHang.Name = "dgvChonMatHang";
            this.dgvChonMatHang.Size = new System.Drawing.Size(941, 265);
            this.dgvChonMatHang.TabIndex = 0;
            // 
            // MACTHDX
            // 
            this.MACTHDX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACTHDX.DataPropertyName = "MACTHDX";
            this.MACTHDX.HeaderText = "Mã Chi Tiết HD";
            this.MACTHDX.Name = "MACTHDX";
            // 
            // MAHDX
            // 
            this.MAHDX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHDX.DataPropertyName = "MAHDX";
            this.MAHDX.HeaderText = "Mã Hóa Đơn Xuất";
            this.MAHDX.Name = "MAHDX";
            // 
            // MAHANGHOA
            // 
            this.MAHANGHOA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHANGHOA.DataPropertyName = "MAHANGHOA";
            this.MAHANGHOA.HeaderText = "Mã Hàng Hóa";
            this.MAHANGHOA.Name = "MAHANGHOA";
            // 
            // TENHANGHOA
            // 
            this.TENHANGHOA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENHANGHOA.DataPropertyName = "TENHANGHOA";
            this.TENHANGHOA.HeaderText = "Tên Hàng Hóa";
            this.TENHANGHOA.Name = "TENHANGHOA";
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
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(179, 164);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(219, 20);
            this.txtSoLuong.TabIndex = 27;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Số Lượng";
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDonHang.Location = new System.Drawing.Point(179, 190);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(146, 28);
            this.btnThemDonHang.TabIndex = 28;
            this.btnThemDonHang.Text = "Thêm Đơn Hàng";
            this.btnThemDonHang.UseVisualStyleBackColor = true;
            this.btnThemDonHang.Click += new System.EventHandler(this.btnThemDonHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Location = new System.Drawing.Point(419, 90);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(150, 28);
            this.btnThemKhachHang.TabIndex = 29;
            this.btnThemKhachHang.Text = "Thêm Khách Hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(829, 208);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(172, 28);
            this.btnTinhTien.TabIndex = 30;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnXoaDonHang
            // 
            this.btnXoaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDonHang.Location = new System.Drawing.Point(340, 190);
            this.btnXoaDonHang.Name = "btnXoaDonHang";
            this.btnXoaDonHang.Size = new System.Drawing.Size(58, 28);
            this.btnXoaDonHang.TabIndex = 31;
            this.btnXoaDonHang.Text = "Xóa";
            this.btnXoaDonHang.UseVisualStyleBackColor = true;
            // 
            // cboTenHangHoa
            // 
            this.cboTenHangHoa.FormattingEnabled = true;
            this.cboTenHangHoa.Location = new System.Drawing.Point(179, 128);
            this.cboTenHangHoa.Name = "cboTenHangHoa";
            this.cboTenHangHoa.Size = new System.Drawing.Size(219, 21);
            this.cboTenHangHoa.TabIndex = 32;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 561);
            this.ControlBox = false;
            this.Controls.Add(this.cboTenHangHoa);
            this.Controls.Add(this.btnXoaDonHang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThemKhachHang);
            this.Controls.Add(this.btnThemDonHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbChonHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbBanHang);
            this.Controls.Add(this.label1);
            this.Name = "FrmBanHang";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBanHang)).EndInit();
            this.grbChonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbBanHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.GroupBox grbChonHang;
        private System.Windows.Forms.DataGridView dgvChonMatHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemDonHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnXoaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.ComboBox cboTenHangHoa;
    }
}