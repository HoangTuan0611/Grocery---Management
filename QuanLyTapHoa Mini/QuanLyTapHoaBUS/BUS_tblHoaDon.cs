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
   public class BUS_tblHoaDon
    {
        SQL_tblHoaDon sql = new SQL_tblHoaDon();
        public void ThemDuLieu(EC_tblHoaDon et)
        {
            sql.ThemDuLieu(et);
        }

        public void SuaDuLieu(EC_tblHoaDon et)
        {
            sql.SuaDuLieu(et);
        }

        public void XoaDuLieu(EC_tblHoaDon et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }

        public DataTable LayThongTinKH(string DieuKien)
        {
            return sql.LayThongTinKH(DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return sql.LayThongTinNV(DieuKien);
        }
    }
}
