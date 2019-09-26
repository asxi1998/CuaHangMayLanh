namespace Windows_CHMayLanh
{
    partial class FrmThemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemKhachHang));
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(352, 221);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 37);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Thêm Khách Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaKhachHang.Location = new System.Drawing.Point(352, 107);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtMaKhachHang.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenKhachHang.Location = new System.Drawing.Point(352, 145);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(190, 20);
            this.txtTenKhachHang.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiaChi.Location = new System.Drawing.Point(352, 183);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(372, 20);
            this.txtDiaChi.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 93;
            this.label3.Text = "Địa Chỉ";
            // 
            // FrmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 340);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Name = "FrmThemKhachHang";
            this.Text = "FrmThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
    }
}