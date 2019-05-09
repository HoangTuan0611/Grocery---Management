using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTapHoaEmtity
{
   public class EC_tblHoaDon
    {
        private string _MaHD;
        private string _MaKH;
        private string _MaNV;
        private string _NgayLap;

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
        public string NgayLap
        {
            get
            {
                return _NgayLap;
            }

            set
            {
                _NgayLap = value;
            }
        }
    }
}
