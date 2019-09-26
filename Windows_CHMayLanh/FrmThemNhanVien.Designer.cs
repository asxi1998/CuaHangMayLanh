namespace Windows_CHMayLanh
{
    partial class FrmThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemNhanVien));
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(308, 353);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 37);
            this.btnThem.TabIndex = 70;
            this.btnThem.Text = "Thêm Nhân Viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGioiTinh.Location = new System.Drawing.Point(308, 128);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(190, 20);
            this.txtGioiTinh.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(222, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 68;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Vào Làm";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhanVien.Location = new System.Drawing.Point(308, 14);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(190, 20);
            this.txtMaNhanVien.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaPhongBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaPhongBan.Location = new System.Drawing.Point(308, 52);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(190, 20);
            this.txtMaPhongBan.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // txtTen
            // 
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTen.Location = new System.Drawing.Point(308, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(190, 20);
            this.txtTen.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Mã Phòng Ban";
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox3.Location = new System.Drawing.Point(310, 239);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 20);
            this.textBox3.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 77;
            this.label7.Text = "Lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ngày Sinh";
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox5.Location = new System.Drawing.Point(308, 315);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(358, 20);
            this.textBox5.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 81;
            this.label9.Text = "Địa Chỉ";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDienThoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDienThoai.Location = new System.Drawing.Point(309, 277);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(190, 20);
            this.txtDienThoai.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(210, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 79;
            this.label10.Text = "Điện Thoại";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 201);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 83;
            this.dateTimePicker1.Value = new System.DateTime(2018, 10, 14, 21, 8, 31, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 163);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker2.TabIndex = 84;
            this.dateTimePicker2.Value = new System.DateTime(2018, 10, 14, 21, 8, 31, 0);
            // 
            // FrmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 414);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaPhongBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label2);
            this.Name = "FrmThemNhanVien";
            this.Text = "FrmThemNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}