namespace Windows_CHMayLanh
{
    partial class FrmQuanLyKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKho));
            this.pcbQLKho = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKho = new System.Windows.Forms.GroupBox();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MAHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANGHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLKho)).BeginInit();
            this.grbKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbQLKho
            // 
            this.pcbQLKho.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbQLKho.Image = ((System.Drawing.Image)(resources.GetObject("pcbQLKho.Image")));
            this.pcbQLKho.InitialImage = null;
            this.pcbQLKho.Location = new System.Drawing.Point(153, 12);
            this.pcbQLKho.Name = "pcbQLKho";
            this.pcbQLKho.Size = new System.Drawing.Size(50, 50);
            this.pcbQLKho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQLKho.TabIndex = 9;
            this.pcbQLKho.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kho Hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaHang.Location = new System.Drawing.Point(153, 116);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(190, 20);
            this.txtMaHang.TabIndex = 43;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNCC.Location = new System.Drawing.Point(153, 78);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(190, 20);
            this.txtMaNCC.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã Hàng Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // grbKho
            // 
            this.grbKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbKho.AutoSize = true;
            this.grbKho.Controls.Add(this.dgvKho);
            this.grbKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKho.Location = new System.Drawing.Point(21, 162);
            this.grbKho.Name = "grbKho";
            this.grbKho.Size = new System.Drawing.Size(969, 356);
            this.grbKho.TabIndex = 44;
            this.grbKho.TabStop = false;
            this.grbKho.Text = "Kho Hàng";
            // 
            // dgvKho
            // 
            this.dgvKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANGHOA,
            this.TENHANGHOA,
            this.SOLUONG,
            this.DONGIA,
            this.MANCC});
            this.dgvKho.Location = new System.Drawing.Point(6, 28);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.Size = new System.Drawing.Size(956, 321);
            this.dgvKho.TabIndex = 0;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNgayNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNgayNhap.Location = new System.Drawing.Point(483, 77);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(190, 20);
            this.txtNgayNhap.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ngày Nhập";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenHangHoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenHangHoa.Location = new System.Drawing.Point(483, 116);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(190, 20);
            this.txtTenHangHoa.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tên Hàng Hóa";
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
            // MANCC
            // 
            this.MANCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MANCC.Name = "MANCC";
            // 
            // FrmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1002, 508);
            this.ControlBox = false;
            this.Controls.Add(this.txtTenHangHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbKho);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbQLKho);
            this.Name = "FrmQuanLyKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLKho)).EndInit();
            this.grbKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbQLKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbKho;
        private System.Windows.Forms.DataGridView dgvKho;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANGHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
    }
}