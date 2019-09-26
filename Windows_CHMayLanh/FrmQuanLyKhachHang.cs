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
    public partial class FrmQuanLyKhachHang : Form
    {
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemKhachHang frm = new FrmThemKhachHang();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSuaKhachHang frm = new FrmSuaKhachHang();
            frm.ShowDialog();
        }
    }
}
