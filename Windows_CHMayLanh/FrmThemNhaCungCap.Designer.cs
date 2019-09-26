namespace Windows_CHMayLanh
{
    partial class FrmThemNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemNhaCungCap));
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDiaChi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiaChi.Location = new System.Drawing.Point(358, 220);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(372, 20);
            this.txtDiaChi.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "Địa Chỉ";
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(358, 182);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(190, 20);
            this.txtTenNhaCungCap.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(358, 258);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 37);
            this.btnThem.TabIndex = 110;
            this.btnThem.Text = "Thêm Nhà Cung Câp";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaNhaCungCap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(358, 144);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(190, 20);
            this.txtMaNhaCungCap.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 108;
            this.label2.Text = "Mã Nhà Cung Cấp";
            // 
            // FrmThemNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 375);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaNhaCungCap);
            this.Controls.Add(this.label2);
            this.Name = "FrmThemNhaCungCap";
            this.Text = "FrmThemNhaCungCap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label label2;
    }
}