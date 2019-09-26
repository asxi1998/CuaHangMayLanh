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
    public partial class FrmQuangLyNhaCungCap : Form
    {
        public FrmQuangLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNhaCungCap frm = new FrmThemNhaCungCap();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSuaNhaCungCap frm = new FrmSuaNhaCungCap();
            frm.ShowDialog();
        }
    }
}
