using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTapHoaEmtity
{
    public class EC_tblKhachHang
    {

        private string _MaKH;
        private string _TenKH;
        private string _DiaChi;
        private string _DienThoai;

        public string MaKH
        {
            get
            {
                return _MaKH;
            }

            set
            {
                _MaKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }

            set
            {
                _TenKH = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }

            set
            {
                _DienThoai = value;
            }
        }
    }
}
