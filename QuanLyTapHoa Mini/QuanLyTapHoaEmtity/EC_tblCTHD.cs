using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTapHoaEmtity
{
   public class EC_tblCTHD
    {

        private string _MaHD;
        private string _MaHang;
        private string _SoLuongMua;
        private string _DonGiaBan;
        private string _ThanhTien;

        public string MaHD
        {
            get
            {
                return _MaHD;
            }

            set
            {
                _MaHD = value;
            }
        }

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

        public string SoLuongMua
        {
            get
            {
                return _SoLuongMua;
            }

            set
            {
                _SoLuongMua = value;
            }
        }

        public string DonGiaBan
        {
            get
            {
                return _DonGiaBan;
            }

            set
            {
                _DonGiaBan = value;
            }
        }

        public string ThanhTien
        {
            get
            {
                return _ThanhTien;
            }

            set
            {
                _ThanhTien = value;
            }
        }
    }
}
