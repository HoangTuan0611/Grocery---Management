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
    public class BUS_tblNhanVien
    {
        SQL_tblNhanVien sql = new SQL_tblNhanVien();

        // Thêm Dữ Liệu
        public void ThemDuLieu(EC_tblNhanVien et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(EC_tblNhanVien et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(EC_tblNhanVien et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblNhanVien where MaNV ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}

