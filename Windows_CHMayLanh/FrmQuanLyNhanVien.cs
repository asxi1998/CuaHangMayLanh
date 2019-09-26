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
    public partial class FrmQuanLyNhanVien : Form
    {
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            ConectToDataBase.Conect();
            dgvNhanVien.DataSource = ConectToDataBase.GetData("select * from NHANVIEN ");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frm = new FrmThemNhanVien();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSuaNhanVien frm = new FrmSuaNhanVien();
            frm.ShowDialog();
        }
    }
}
