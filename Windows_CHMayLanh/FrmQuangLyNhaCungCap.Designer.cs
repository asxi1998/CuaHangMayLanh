namespace Windows_CHMayLanh
{
    partial class FrmQuangLyNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuangLyNhaCungCap));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbNhaCungCap = new System.Windows.Forms.GroupBox();
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbQLNhaCungCap = new System.Windows.Forms.PictureBox();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(613, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Nút Hỗ Trợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Tìm Kiếm Nhà Cung Cấp";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(799, 132);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 40);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(704, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(609, 132);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 40);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(176, 116);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(190, 20);
            this.txtTenNhaCungCap.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Tên Nhà Cung Cấp";
            // 
            // grbNhaCungCap
            // 
            this.grbNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhaCungCap.AutoSize = true;
            this.grbNhaCungCap.Controls.Add(this.dgvNhaCungCap);
            this.grbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhaCungCap.Location = new System.Drawing.Point(29, 193);
            this.grbNhaCungCap.Name = "grbNhaCungCap";
            this.grbNhaCungCap.Size = new System.Drawing.Size(958, 363);
            this.grbNhaCungCap.TabIndex = 71;
            this.grbNhaCungCap.TabStop = false;
            this.grbNhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANCC,
            this.TENNCC,
            this.DIACHI});
            this.dgvNhaCungCap.Location = new System.Drawing.Point(7, 29);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.Size = new System.Drawing.Size(945, 328);
            this.dgvNhaCungCap.TabIndex = 0;
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(176, 152);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(190, 20);
            this.txtMaNhaCungCap.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 33);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nhà Cung Cấp";
            // 
            // pcbQLNhaCungCap
            // 
            this.pcbQLNhaCungCap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pcbQLNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("pcbQLNhaCungCap.Image")));
            this.pcbQLNhaCungCap.InitialImage = null;
            this.pcbQLNhaCungCap.Location = new System.Drawing.Point(210, 12);
            this.pcbQLNhaCungCap.Name = "pcbQLNhaCungCap";
            this.pcbQLNhaCungCap.Size = new System.Drawing.Size(50, 50);
            this.pcbQLNhaCungCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQLNhaCungCap.TabIndex = 82;
            this.pcbQLNhaCungCap.TabStop = false;
            // 
            // MANCC
            // 
            this.MANCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MANCC.Name = "MANCC";
            // 
            // TENNCC
            // 
            this.TENNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TENNCC.Name = "TENNCC";
            // 
            // DIACHI
            // 
            this.DIACHI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHI.DataPropertyName = "MAKH";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            // 
            // FrmQuangLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1017, 568);
            this.ControlBox = false;
            this.Controls.Add(this.pcbQLNhaCungCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbNhaCungCap);
            this.Controls.Add(this.txtMaNhaCungCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FrmQuangLyNhaCungCap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbNhaCungCap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQLNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbNhaCungCap;
        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbQLNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
    }
}