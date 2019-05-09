using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoaDAL
{
   public class SQL_tblKhachHang
    {

        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(EC_tblKhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblKhachHang (MaKH, TenKH, DiaChi, DienThoai) VALUES  ('" + et.MaKH + "',N'" + et.TenKH + "',N'" + et.DiaChi + "',N'" + et.DienThoai + "')");
        }
        //Sửa
        public void SuaDuLieu(EC_tblKhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblKhachHang SET TenKH = N'" + et.TenKH + "', DiaChi =N'" + et.DiaChi + "', DienThoai ='" + et.DienThoai + "' Where MaKH='" + et.MaKH + "'");
        }
        //Xoá
        public void XoaDuLieu(EC_tblKhachHang et)
        {
           
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblKhachHang  Where MaKH='" + et.MaKH + "'");           
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblKhachHang " + DieuKien);
        }
    }
}
