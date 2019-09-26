namespace Windows_CHMayLanh
{
    partial class FrmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao));
            this.label3 = new System.Windows.Forms.Label();
            this.pcbBaoCao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 33);
            this.label3.TabIndex = 83;
            this.label3.Text = "Báo Cáo";
            // 
            // pcbBaoCao
            // 
            this.pcbBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("pcbBaoCao.Image")));
            this.pcbBaoCao.InitialImage = null;
            this.pcbBaoCao.Location = new System.Drawing.Point(128, 12);
            this.pcbBaoCao.Name = "pcbBaoCao";
            this.pcbBaoCao.Size = new System.Drawing.Size(50, 50);
            this.pcbBaoCao.TabIndex = 84;
            this.pcbBaoCao.TabStop = false;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(964, 440);
            this.ControlBox = false;
            this.Controls.Add(this.pcbBaoCao);
            this.Controls.Add(this.label3);
            this.Name = "FrmBaoCao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbBaoCao;
    }
}