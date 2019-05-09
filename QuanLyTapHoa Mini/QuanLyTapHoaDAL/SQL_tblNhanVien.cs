using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoaDAL
{
   public class SQL_tblNhanVien
    {

        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(EC_tblNhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblNhanVien (MaNV, TenNV, DiaChi, DienThoai) VALUES  ('" + et.MaNV + "',N'" + et.TenNV + "',N'" + et.DiaChi + "',N'" + et.DienThoai + "')");
        }
        //Sửa
        public void SuaDuLieu(EC_tblNhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblNhanVien SET TenKH = N'" + et.TenNV + "', DiaChi =N'" + et.DiaChi + "', DienThoai ='" + et.DienThoai + "' Where MaNV='" + et.MaNV + "'");
        }
        //Xoá
        public void XoaDuLieu(EC_tblNhanVien et)
        {

            cn.ThucThiCauLenhSQL(@"DELETE FROM tblNhanVien  Where MaNV='" + et.MaNV + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblNhanVien where MaNV ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblNhanVien " + DieuKien);
        }
    }
}
