namespace Windows_CHMayLanh
{
    partial class FrmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNhanVien));
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayVaoLam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtBoPhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbQLNhanVien = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVAOLAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNhanVien.Location = new System.Drawing.Point(463, 154);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(190, 20);
            this.txtTenNhanVien.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // txtNgayVaoLam
            // 
            this.txtNgayVaoLam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNgayVaoLam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNgayVaoLam.Location = new System.Drawing.Point(463, 115);
            this.txtNgayVaoLam.Name = "txtNgayVaoLam";
            this.txtNgayVaoLam.Size = new System.Drawing.Size(190, 20);
            this.txtNgayVaoLam.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ngày Vào Làm";
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhanVien.AutoSize = true;
            this.grbNhanVien.Controls.Add(this.dgvNhanVien);
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(20, 191);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(1043, 363);
            this.grbNhanVien.TabIndex = 55;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.MABP,
            this.TENNV,
            this.GIOITINH,
            this.NGAYVAOLAM,
            this.NGAYSINH,
            this.DIENTHOAI,
            this.DIACHI});
            this.dgvNhanVien.Location = new System.Drawing.Point(7, 29);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1030, 328);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhanVien.Location = new System.Drawing.Point(133, 154);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(190, 20);
            this.txtMaNhanVien.TabIndex = 54;
            // 
            // txtBoPhan
            // 
            this.txtBoPhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoPhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoPhan.Location = new System.Drawing.Point(133, 116);
            this.txtBoPhan.Name = "txtBoPhan";
            this.txtBoPhan.Size = new System.Drawing.Size(190, 20);
            this.txtBoPhan.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bộ Phận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nhân Viên";
            // 
            // pcbQLNhanVien
            // 
            this.pcbQLNhanVien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("pcbQLNhanVien.Image")));
            this.pcbQLNhanVien.InitialImage = null;
            this.pcbQLNhanVien.Location = new System.Drawing.Point(214, 12);
            this.pcbQLNhanVien.Name = "pcbQLNhanVien";
            this.pcbQLNhanVien.Size = new System.Drawing.Size(50, 50);
            this.pcbQLNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQLNhanVien.TabIndex = 60;
            this.pcbQLNhanVien.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(785, 132);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 40);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(880, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(975, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 40);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tìm Kiếm Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(789, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Nút Hỗ Trợ";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            // 
            // MABP
            // 
            this.MABP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MABP.DataPropertyName = "MABP";
            this.MABP.HeaderText = "Mã Bộ Phận";
            this.MABP.Name = "MABP";
            // 
            // TENNV
            // 
            this.TENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.Name = "TENNV";
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // NGAYVAOLAM
            // 
            this.NGAYVAOLAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYVAOLAM.DataPropertyName = "NGAYVAOLAM";
            this.NGAYVAOLAM.HeaderText = "Ngày Vào Làm";
            this.NGAYVAOLAM.Name = "NGAYVAOLAM";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "Điện Thoại";
            this.DIENTHOAI.Name = "DIENTHOAI";
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pcbQLNhanVien);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayVaoLam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtBoPhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FrmQuanLyNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyNhanVien_Load);
            this.grbNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayVaoLam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtBoPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbQLNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVAOLAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}