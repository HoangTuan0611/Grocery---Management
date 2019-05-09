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
   public class BUS_tblKhachHang
    {
        SQL_tblKhachHang sql = new SQL_tblKhachHang();

        // Thêm Dữ Liệu
        public void ThemDuLieu(EC_tblKhachHang et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(EC_tblKhachHang et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(EC_tblKhachHang et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
