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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        FrmDangNhap frmDN = new FrmDangNhap();
        private void pcbDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã đăng nhập.");
        }

        private void pcbDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDN.Show();
        }
        
        private void pcbTaiKhoan_Click(object sender, EventArgs e)
        {
            panelQuanTriHeThong.Controls.Clear();//clear mang hình panel
            FrmTaiKhoan frm = new FrmTaiKhoan();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanTriHeThong.Controls.Add(frm);
            
            frm.Show();
            //
        }


        private void pcbPhanQuyen_Click(object sender, EventArgs e)
        {
            panelQuanTriHeThong.Controls.Clear();//clear mang hình panel
            FrmPhanQuyen frm = new FrmPhanQuyen();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanTriHeThong.Controls.Add(frm);
            
            frm.Show();
            //
        }
        
        


        //tabpage2---------------------------------------------------
        private void pcbBanHang_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmBanHang frm = new FrmBanHang();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
           
            frm.Show();
            //
        }

        private void pcbNhapHang_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmNhapHang frm = new FrmNhapHang();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);
           
            frm.Show();
            //
        }

        private void pcbQLKho_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmQuanLyKho frm = new FrmQuanLyKho();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }

        private void pcbQLNhanVien_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmQuanLyNhanVien frm = new FrmQuanLyNhanVien();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }

        private void pcbQLKhachHang_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmQuanLyKhachHang frm = new FrmQuanLyKhachHang();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }

        private void pcbQLNhaCungCap_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmQuangLyNhaCungCap frm = new FrmQuangLyNhaCungCap();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }

        private void pcbBaoCao_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmBaoCao frm = new FrmBaoCao();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }

        private void pcbThongKe_Click(object sender, EventArgs e)
        {
            panelQuanLyNghiepVu.Controls.Clear();//clear mang hình panel
            FrmThongKe frm = new FrmThongKe();//khởi tạo form Tài Khoản
            //thêm vào panel chinh 1 form mới
            this.IsMdiContainer = true;//tùy chỉnh trong form chính thuộc tính IsMdiContainer cho ko tràng form
            frm.MdiParent = this;
            this.panelQuanLyNghiepVu.Controls.Add(frm);

            frm.Show();
            //
        }



        private void panelQuanTriHeThong_Resize(object sender, EventArgs e)
        {
            //thay đổi kích cở của form con luôn theo form cha
            foreach (Form frm in panelQuanTriHeThong.Controls) // Lặp từng button trong Panel
            {
                frm.WindowState = FormWindowState.Normal;//thu nhỏ form con
                frm.WindowState = FormWindowState.Maximized;//phóng to form con
            }
        }

        private void panelQuanLyNghiepVu_Resize(object sender, EventArgs e)
        {
            //thay đổi kích cở của form con luôn theo form cha
            foreach (Form frm in panelQuanLyNghiepVu.Controls) // Lặp từng button trong Panel
            {
                frm.WindowState = FormWindowState.Normal;//thu nhỏ form con
                frm.WindowState = FormWindowState.Maximized;//phóng to form con
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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

        
    }
}
