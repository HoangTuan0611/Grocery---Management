using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTapHoaEmtity
{
    public class EC_tblNhanVien
    {

        private string _MaNV;
        private string _TenNV;
        private string _DiaChi;
        private string _DienThoai;

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                _MaNV = value;
            }
        }

        public string TenNV
        {
            get
            {
                return _TenNV;
            }

            set
            {
                _TenNV = value;
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
