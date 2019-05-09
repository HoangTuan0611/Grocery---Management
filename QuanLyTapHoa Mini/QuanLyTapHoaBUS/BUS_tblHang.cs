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
   public class BUS_tblHang
    {
        SQL_tblHang sql = new SQL_tblHang();

        public void ThemDuLieu(EC_tblHang et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(EC_tblHang et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(EC_tblHang et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
