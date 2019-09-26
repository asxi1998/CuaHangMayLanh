using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_CHMayLanh
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Properties.Settings.Default.TAIKHOAN ;
            txtMatKhau.Text = Properties.Settings.Default.MATKHAU ;
            ckbNho.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã nhập tên tài khoản và pass chưa
            string user = txtTaiKhoan.Text.Trim();//get dữ liệu từ textbox tài khoản
            string pass = txtMatKhau.Text;//get dữ liệu từ textbox mật khẩu
            if (user == string.Empty)//kiểm tra tài khoản có được nhập chưa
            {
                MessageBox.Show("Hãy nhập tài khoản ");
            }
            else
            {
                if (pass == string.Empty)
                    MessageBox.Show("Hãy nhập Password");
                else
                {
                    try
                    {
                       
                        //kết nối SQL 
                        SqlConnection conn = new SqlConnection(@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True");
                        conn.Open();
                        //đưa tài khoản ,mật khẩu xuống SQL 
                        string src = "select NGUOIDUNG.MAND,NGUOIDUNG.MATKHAU from NGUOIDUNG where NGUOIDUNG.MAND='" + txtTaiKhoan.Text + "'and NGUOIDUNG.MATKHAU='" + txtMatKhau.Text + "'";
                        SqlCommand cmd = new SqlCommand(src, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        //
                        if (dr.Read())//có tài khoản mật khẩu như vậy thì vào Main chính
                        {
                            conn.Close();
                            this.Hide();//form đăng nhập ẩn
                            frmMain frm = new frmMain();
                            frm.Show();
                        }
                        else
                        {
                            conn.Close();
                            MessageBox.Show("Đăng Nhập Thất Bại");
                            
                        }
                        if (ckbNho.Checked == true)//lưu tài khoản mật khẩu
                        {
                            Properties.Settings.Default.TAIKHOAN = txtTaiKhoan.Text;
                            Properties.Settings.Default.MATKHAU = txtMatKhau.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.TAIKHOAN = "";
                            Properties.Settings.Default.MATKHAU = "";
                            Properties.Settings.Default.Save();
                            
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi!!!!!!!!");
                    }
                }
            }
        }


        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != string.Empty)
            {
                if (txtMatKhau.Text != string.Empty)
                {
                    btnDangNhap.Enabled = true;
                }
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != string.Empty)
            {
                if (txtMatKhau.Text != string.Empty)
                {
                    btnDangNhap.Enabled = true;
                }
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }
        public string getMaNV()
        {
            return txtTaiKhoan.Text;
        }
        public string getTenNV()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True");
            conn.Open();
            string src = "select * from NHANVIEN where NHANVIEN.MANV='" + txtTaiKhoan.Text + "'";
            SqlCommand cmd = new SqlCommand(src, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string TenNV = "";
            while (dr.Read())
            {
                TenNV = dr["TENNV"].ToString();
            }
            dr.Close();
            conn.Close();
            return TenNV;
        }

    }
}
