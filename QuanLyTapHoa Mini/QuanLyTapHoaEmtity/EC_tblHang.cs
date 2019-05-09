using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTapHoaEmtity
{
   public class EC_tblHang
    {
        private string _MaHang;
        private string _TenHang;
        private string _DonGiaHang;
        private string _NhaSX;
        private string _MoTa;

        public string MaHang
        {
            get
            {
                return _MaHang;
            }

            set
            {
                _MaHang = value;
            }
        }

        public string TenHang
        {
            get
            {
                return _TenHang;
            }

            set
            {
                _TenHang = value;
            }
        }

        public string DonGiaHang
        {
            get
            {
                return _DonGiaHang;
            }

            set
            {
                _DonGiaHang = value;
            }
        }

        public string NhaSX
        {
            get
            {
                return _NhaSX;
            }

            set
            {
                _NhaSX = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _MoTa;
            }

            set
            {
                _MoTa = value;
            }
        }
    }
}
