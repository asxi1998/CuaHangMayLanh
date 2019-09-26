namespace Windows_CHMayLanh
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.label3 = new System.Windows.Forms.Label();
            this.pcbThongKe = new System.Windows.Forms.PictureBox();
            this.grbNhaCungCap = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThongKe)).BeginInit();
            this.grbNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 33);
            this.label3.TabIndex = 47;
            this.label3.Text = "Thống Kê";
            // 
            // pcbThongKe
            // 
            this.pcbThongKe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbThongKe.Image = ((System.Drawing.Image)(resources.GetObject("pcbThongKe.Image")));
            this.pcbThongKe.InitialImage = null;
            this.pcbThongKe.Location = new System.Drawing.Point(69, 4);
            this.pcbThongKe.Name = "pcbThongKe";
            this.pcbThongKe.Size = new System.Drawing.Size(50, 50);
            this.pcbThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbThongKe.TabIndex = 54;
            this.pcbThongKe.TabStop = false;
            // 
            // grbNhaCungCap
            // 
            this.grbNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhaCungCap.AutoSize = true;
            this.grbNhaCungCap.Controls.Add(this.dgvThongKe);
            this.grbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhaCungCap.Location = new System.Drawing.Point(30, 60);
            this.grbNhaCungCap.Name = "grbNhaCungCap";
            this.grbNhaCungCap.Size = new System.Drawing.Size(987, 394);
            this.grbNhaCungCap.TabIndex = 72;
            this.grbNhaCungCap.TabStop = false;
            this.grbNhaCungCap.Text = "Thống Kê Doanh Số Của Tháng";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAHANGHOA,
            this.TENHANGHOA,
            this.SOLUONG,
            this.DONGIA,
            this.TONGTIEN,
            this.NGAY,
            this.TENNCC});
            this.dgvThongKe.Location = new System.Drawing.Point(7, 29);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(974, 359);
            this.dgvThongKe.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
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
            // TONGTIEN
            // 
            this.TONGTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // NGAY
            // 
            this.NGAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAY.DataPropertyName = "NGAY";
            this.NGAY.HeaderText = "Ngày";
            this.NGAY.Name = "NGAY";
            // 
            // TENNCC
            // 
            this.TENNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TENNCC.Name = "TENNCC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tổng Tiền";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(753, 460);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 74;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 494);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbNhaCungCap);
            this.Controls.Add(this.pcbThongKe);
            this.Controls.Add(this.label3);
            this.Name = "FrmThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbThongKe)).EndInit();
            this.grbNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbThongKe;
        private System.Windows.Forms.GroupBox grbNhaCungCap;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}