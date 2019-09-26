namespace Windows_CHMayLanh
{
    partial class FrmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyKhachHang));
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbQLKhachHang = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbKhachHang.AutoSize = true;
            this.grbKhachHang.Controls.Add(this.dgvKhachHang);
            this.grbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhachHang.Location = new System.Drawing.Point(24, 195);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(878, 320);
            this.grbKhachHang.TabIndex = 56;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Danh Sách Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.DIACHI});
            this.dgvKhachHang.Location = new System.Drawing.Point(7, 29);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(865, 284);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 33);
            this.label3.TabIndex = 49;
            this.label3.Text = "Khách Hàng";
            // 
            // pcbQLKhachHang
            // 
            this.pcbQLKhachHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbQLKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("pcbQLKhachHang.Image")));
            this.pcbQLKhachHang.ImageLocation = "";
            this.pcbQLKhachHang.InitialImage = null;
            this.pcbQLKhachHang.Location = new System.Drawing.Point(159, 12);
            this.pcbQLKhachHang.Name = "pcbQLKhachHang";
            this.pcbQLKhachHang.Size = new System.Drawing.Size(50, 50);
            this.pcbQLKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQLKhachHang.TabIndex = 63;
            this.pcbQLKhachHang.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Nút Hỗ Trợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Tìm Kiếm Khách Hàng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(745, 138);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 40);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(650, 138);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 75;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(555, 138);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 40);
            this.btnThem.TabIndex = 74;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenKhachHang.Location = new System.Drawing.Point(159, 126);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtTenKhachHang.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tên Khách Hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaKhachHang.Location = new System.Drawing.Point(161, 162);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtMaKhachHang.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // MAKH
            // 
            this.MAKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.Name = "MAKH";
            // 
            // TENKH
            // 
            this.TENKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.Name = "TENKH";
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // FrmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbQLKhachHang);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.label3);
            this.Name = "FrmQuanLyKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbQLKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}