using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Windows_CHMayLanh
{
    class ConectToDataBase
    {
        static SqlCommand cmd;
        static SqlConnection conn;
        static SqlDataAdapter adapter;
        public static string sql=@"Data Source=CAM-PC\SQLEXPRESS;Initial Catalog=QuanLyMayLanh;Integrated Security=True";

        public static void Conect()
        {
            conn = new SqlConnection(ConectToDataBase.sql);
            conn.Open();
        }
        public static void Excute(string query)
        {
            cmd = new SqlCommand(query,conn);
            cmd.ExecuteNonQuery();
        }
        public static DataTable GetData(string query)
        {
            cmd = new SqlCommand(query,conn);
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }
        
    }
}
