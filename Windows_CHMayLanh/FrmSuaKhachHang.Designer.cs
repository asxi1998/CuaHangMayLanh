namespace Windows_CHMayLanh
{
    partial class FrmSuaKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaKhachHang));
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiaChi.Location = new System.Drawing.Point(383, 240);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(372, 20);
            this.txtDiaChi.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 100;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenKhachHang.Location = new System.Drawing.Point(383, 202);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtTenKhachHang.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(383, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 37);
            this.btnSua.TabIndex = 97;
            this.btnSua.Text = "Sửa Khách Hàng";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaKhachHang.Location = new System.Drawing.Point(383, 164);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtMaKhachHang.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenCu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaCu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 88);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng Cần Sửa";
            // 
            // txtTenCu
            // 
            this.txtTenCu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenCu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenCu.Enabled = false;
            this.txtTenCu.Location = new System.Drawing.Point(135, 57);
            this.txtTenCu.Name = "txtTenCu";
            this.txtTenCu.Size = new System.Drawing.Size(190, 24);
            this.txtTenCu.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // txtMaCu
            // 
            this.txtMaCu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaCu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaCu.Enabled = false;
            this.txtMaCu.Location = new System.Drawing.Point(135, 30);
            this.txtMaCu.Name = "txtMaCu";
            this.txtMaCu.Size = new System.Drawing.Size(190, 24);
            this.txtMaCu.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 100;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // FrmSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Name = "FrmSuaKhachHang";
            this.Text = "FrmSuaKhachHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaCu;
        private System.Windows.Forms.Label label5;
    }
}