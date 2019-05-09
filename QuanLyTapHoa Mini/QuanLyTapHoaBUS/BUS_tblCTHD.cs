    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
using QuanLyTapHoaDAL;
namespace QuanLyTapHoaBUS
{
   public class BUS_tblCTHD
    {
        SQL_tblCTHD sql = new SQL_tblCTHD();
       /* public int KiemTra(string mahd, string mahang)
        {
            return sql.KiemTra(mahd, mahang);
        }
        */
        public void ThemDuLieu(EC_tblCTHD et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(EC_tblCTHD et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(EC_tblCTHD et)
        {
            sql.XoaDuLieu(et);
        }

        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
        public DataTable LayThongTinMH(string DieuKien)
        {
            return sql.LayThongTinMH(DieuKien);
        }
       
    }
}
