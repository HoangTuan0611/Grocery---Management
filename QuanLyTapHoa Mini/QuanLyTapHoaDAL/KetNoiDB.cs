using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyTapHoaDAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;
        public static void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection("Data Source=DESKTOP-8I4FATD;Initial Catalog=DataQLTH;Integrated Security=SSPI;");
            
            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }
        
        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {

                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }

        }
        //insert update delete 
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }
        }

        public DataTable GetDataTable(string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }

        public string GetValue(string strSQL)//lệnh select..... lấy dữ liệu ở 1 cột trong bảng!
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            return temp;
        }

    }
}
