using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoaDAL
{
   public class SQL_tblCTHD
    {
        KetNoiDB cn = new KetNoiDB();
        // kiem tra xem mat hang va hoa don co ton tai trong CTHD nay khong
        // neu co ton toi roi  thi no se update cai so luong len chu khong tao moi mua!
       /* public int KiemTra(string mahd, string mahang)
        {
            return int.Parse(cn.GetValue("select count(*) from tblCTHD where MaHD = '" + mahd + "' And MaHang = '" + mahang + "'"));
        }*/

        public void ThemDuLieu(EC_tblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblCTHD (MaHD, MaHang, SoLuongMua, DonGiaBan, ThanhTien) VALUES     ('" + et.MaHD + "','" + et.MaHang + "','" + et.SoLuongMua + "','" + et.DonGiaBan + "',(" + et.SoLuongMua + " * " + et.DonGiaBan + "))");
        }

        public void SuaDuLieu(EC_tblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    tblCTHD SET SoLuongMua ='" + et.SoLuongMua + ", DonGiaBan ='" + et.DonGiaBan + ", ThanhTien =(" + et.SoLuongMua + " * " + et.DonGiaBan + ") Where MaHD='" + et.MaHD + "' AND MaHang='" + et.MaHang + "'");
        }

        public void XoaDuLieu(EC_tblCTHD et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblCTHD Where MaHD='" + et.MaHD + "' AND MaHang='" + et.MaHang + "'");
        }

        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblCTHD " + DieuKien);
        }
        public DataTable LayThongTinMH(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblHang " + DieuKien);
        }       
    }
}
