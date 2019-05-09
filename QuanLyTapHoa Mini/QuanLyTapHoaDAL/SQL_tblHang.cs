using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoaDAL
{
   public class SQL_tblHang
    {

        KetNoiDB cn = new KetNoiDB();

        public void ThemDuLieu(EC_tblHang et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblHang (MaHang, TenHang, DonGiaHang, NhaSX, MoTa) VALUES     ('" + et.MaHang + "',N'" + et.TenHang + "','" + et.DonGiaHang + "',N'" + et.NhaSX + "',N'" + et.MoTa + "')");
        }

        public void SuaDuLieu(EC_tblHang et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE    tblHang SET TenHang =N'" + et.TenHang + "', DonGiaHang ='" + et.DonGiaHang + "', NhaSX =N'" + et.NhaSX + "', MoTa =N'" + et.MoTa + "' Where MaHang='" + et.MaHang + "'");
        }

        public void XoaDuLieu(EC_tblHang et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblHang Where MaHang='" + et.MaHang + "'");
        }
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from tblHang " + DieuKien);
        }
    }
}
