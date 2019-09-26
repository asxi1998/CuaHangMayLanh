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
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
            AutocompleteText();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            cboTenHangHoa.SelectedIndex = 0;
        }
        private void Stt()
        {
            for (int i = 0; i <= dgvChonMatHang.Rows.Count - 1; i++)
            {
                dgvChonMatHang.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length > 0 && txtTenKhachHang.Text.Length > 0)
            {
                try
                { 
                SqlConnection conn = new SqlConnection(@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True");
                conn.Open();
                //lấy Mã Hóa Đơn Xuất Mới Nhất
                string src = "select count(*) from HOADONXUAT";
                SqlCommand cmd = new SqlCommand(src, conn);
                int dem = (int)cmd.ExecuteScalar()+1; 
                //lấy Mã Hàng Hóa 
                string src1 = "select * from HANGHOA where HANGHOA.TENHANGHOA=N'" + cboTenHangHoa.Text + "'";
                SqlCommand cmd1 = new SqlCommand(src1, conn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                string MaHH="";
                while (dr1.Read())
                {
                    MaHH = dr1["MAHANGHOA"].ToString();
                }
                dr1.Close();
                //lây Đơn Giá Của Hàng Hóa Đó
                string src2 = "select * from HANGHOA where HANGHOA.TENHANGHOA=N'" + cboTenHangHoa.Text + "'";
                SqlCommand cmd2 = new SqlCommand(src2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                string DonGia="";
                while (dr2.Read())
                {
                    DonGia = dr2["DONGIA"].ToString();
                }
                dr2.Close();

                dgvChonMatHang.Rows.Add(" ", "HDX" + dem.ToString(), MaHH, cboTenHangHoa.Text, txtSoLuong.Text, DonGia);
                Stt();
                conn.Close();
                }
                catch
                {
                    MessageBox.Show("lổi");
                }
            }
            else
                MessageBox.Show("chưa nhập");
        }
        
        void AutocompleteText()
        {
            try
            { 
                //kết nối vói sql
                SqlConnection conn = new SqlConnection(@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True");
                conn.Open();
                //hổ trợ sổ tên khách hàng
                txtTenKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtTenKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection collMAKH = new AutoCompleteStringCollection();
                SqlCommand cmdKHACHHANG = new SqlCommand("select * from KHACHHANG", conn);
                SqlDataReader dataReaderKHACHHANG=cmdKHACHHANG.ExecuteReader(); 
                
                if (dataReaderKHACHHANG != null)
                {
                    while (dataReaderKHACHHANG.Read())
                    {
                        string name = dataReaderKHACHHANG["TENKH"].ToString() + " " + dataReaderKHACHHANG["MAKH"].ToString();//lấy cột MAKH +TENKH
                        collMAKH.Add(name);
                    }
                }
                txtTenKhachHang.AutoCompleteCustomSource = collMAKH;
                dataReaderKHACHHANG.Close();
                //hổ trợ sổ tên hàng hóa
                AutoCompleteStringCollection collMAHANGHOA = new AutoCompleteStringCollection();
                SqlCommand cmdHANGHOA = new SqlCommand("select * from HANGHOA", conn);
                SqlDataReader dataReaderHANGHOA= cmdHANGHOA.ExecuteReader();
                if (dataReaderHANGHOA != null)
                {
                    while (dataReaderHANGHOA.Read())
                    {
                        string name = dataReaderHANGHOA["TENHANGHOA"].ToString();//lấy cột TENHANGHOA
                        cboTenHangHoa.Items.Add(name);
                    }
                }
                dataReaderHANGHOA.Close();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("lổi");
            }
        }
       

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)==false)
                e.Handled = true;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True");
            conn.Open();

            //sử dụng SqlCommandBuilder thêm các Hóa Đơn Xuất vào bảng HDX
            //lấy Mã Khách Hàng
            string MaKH = txtTenKhachHang.Text.Substring(0, txtTenKhachHang.Text.Trim().LastIndexOf(' '));//cắt từ tên khách hàng có hộ trợ +mã Khách trong đó
            FrmDangNhap frmDN = new FrmDangNhap();//goi moi ròi.ko lấy giá trị đc
            string MaNV = "NV1";//frmDN.getMaNV();
            MessageBox.Show(MaNV);
            int tong = 0;
            for (int i = 0; i < dgvChonMatHang.Rows.Count - 1; i++)
            {
                tong += int.Parse(dgvChonMatHang.Rows[i].Cells[4].Value.ToString()) * int.Parse(dgvChonMatHang.Rows[i].Cells[5].Value.ToString());//tổng của số lượng nhân đơn giá . 
            }

            DateTime now = DateTime.Now;
            string src1 = "select * from HOADONXUAT";
            SqlDataAdapter da1 = new SqlDataAdapter(src1, conn);
            SqlCommandBuilder cb1 = new SqlCommandBuilder(da1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "HOADONXUAT");
            DataTable dt1 = ds1.Tables["HOADONXUAT"];
            DataRow dr1 = dt1.NewRow();
            dr1[0] = dgvChonMatHang.Rows[0].Cells[1].Value.ToString();
            dr1[1] = MaKH;
            dr1[2] = MaNV;
            dr1[3] = tong;
            dr1[4] = now.ToShortDateString();
            ds1.Tables["HOADONXUAT"].Rows.Add(dr1);
            da1.Update(ds1, "HOADONXUAT");
            //string src = "insert into HOADONXUAT values( MAHDX='"+dgvChonMatHang.Rows[0].Cells[1].Value.ToString()+"',MAKH='"+MaKH+"',MANV='"+MaNV+"',TONGTIEN='"+tong+"',NGAY='"+now.ToShortDateString()+"')";
            //SqlCommand cmd = new SqlCommand(src, conn);
            //cmd.ExecuteNonQuery();


            //sử dụng SqlCommandBuilder thêm các Chi Tiết Hóa Đơn Xuất vào bảng CTHDX
            string src = "select * from CHITIETHOADONXUAT";
            SqlDataAdapter da = new SqlDataAdapter(src,conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "CHITIETHOADONXUAT");
            DataTable dt = ds.Tables["CHITIETHOADONXUAT"];
            for(int i=0;i<dgvChonMatHang.RowCount-1;i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = dgvChonMatHang.Rows[i].Cells[0].Value.ToString();
                dr[1] = dgvChonMatHang.Rows[i].Cells[1].Value.ToString();
                dr[2] = dgvChonMatHang.Rows[i].Cells[2].Value.ToString();
                dr[3] = int.Parse(dgvChonMatHang.Rows[i].Cells[4].Value.ToString());//bỏ qua cột 3 là cột tên hàng hóa.có thể truy vấn tới HANGHOA để lấy nên ko cần lưu
                dr[4] = int.Parse(dgvChonMatHang.Rows[i].Cells[5].Value.ToString());
                ds.Tables["CHITIETHOADONXUAT"].Rows.Add(dr);
            }
            da.Update(ds, "CHITIETHOADONXUAT");

            conn.Close();
            MessageBox.Show("tổng tiền là:"+tong);
        }

        
    }
}
