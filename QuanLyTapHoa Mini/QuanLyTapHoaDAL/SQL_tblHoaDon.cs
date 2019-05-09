using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoaDAL
{
   public class SQL_tblHoaDon
    {
        KetNoiDB cn = new KetNoiDB();
        // Thêm Dữ Liệu
        public void ThemDuLieu(EC_tblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHoaDon (MaHD, MaKH, MaNV, Ngaylap) VALUES('" + et.MaHD + "','" + et.MaKH + "','" + et.MaNV + "','" + et.NgayLap + "')");
        }
        //Sửa
        public void SuaDuLieu(EC_tblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblHoaDon SET  MaKH ='" + et.MaKH+ "', Ngaylap = '" + et.NgayLap + "' Where MaHD='" + et.MaHD + "'");
        }
        //Xoá
        public void XoaDuLieu(EC_tblHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblHoaDon Where MaHD='" + et.MaHD + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblHoaDon " + DieuKien);
        }
        public DataTable LayThongTinKH(string DieuKien)
        {
            return cn.GetDataTable("Select MaKH,TenKH from tblKhachHang " + DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return cn.GetDataTable("Select MaNV,TenNV from tblNhanVien " + DieuKien);
        }
    }
}
