using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_CHMayLanh
{
    public partial class FrmTaiKhoan : Form
    {
        public FrmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(grbDoiMatKhau.Visible == true)
                grbDoiMatKhau.Visible = false;
            else
                grbDoiMatKhau.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text==txtNhapLaiMK.Text)
            {

            }
            else
            {
                MessageBox.Show("Nhập Lại Mật Khẩu");
                txtMatKhauCu.Clear();
                txtNhapLaiMK.Clear();
                txtMatKhauMoi.Clear();
                txtMatKhauCu.Focus();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            //hiện thị và ẩn password
            if(txtMatKhauCu.PasswordChar == '*')
                txtMatKhauCu.PasswordChar = '\0';
            else
                txtMatKhauCu.PasswordChar = '*';
        }

        private void btnHienThi1_Click(object sender, EventArgs e)
        {
            //hiện thị và ẩn password
            if (txtMatKhauMoi.PasswordChar == '*')
                txtMatKhauMoi.PasswordChar = '\0';
            else
                txtMatKhauMoi.PasswordChar = '*';
        }

        private void btnHienThi2_Click(object sender, EventArgs e)
        {
            //hiện thị và ẩn password
            if (txtNhapLaiMK.PasswordChar == '*')
                txtNhapLaiMK.PasswordChar = '\0';
            else
                txtNhapLaiMK.PasswordChar = '*';
        }
    }
}
