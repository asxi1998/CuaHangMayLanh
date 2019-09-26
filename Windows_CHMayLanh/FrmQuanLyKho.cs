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
    public partial class FrmQuanLyKho : Form
    {
        public FrmQuanLyKho()
        {
            InitializeComponent();
        }

        private void FrmQuanLyKho_Load(object sender, EventArgs e)
        {
            ConectToDataBase.Conect();
            dgvKho.DataSource = ConectToDataBase.GetData("select * from HANGHOA ");
        }
    }
}
