using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTapHoa
{
    public partial class FrmChinh : Form
    {
        // khai báo 1 chuỗi rỗng
        public static string TaiKhoan = string.Empty;
        public FrmChinh()
        {
            InitializeComponent();

        }
        void KhoaDieuKien()
        {
            tbtndangnhap.Enabled = true;
            tbtnhanghoa.Enabled = false;
            tbtnhoadon.Enabled = false;
            tbtnkhachhang.Enabled = false;
            tbtnnhanvien.Enabled = false;
        }



        void MoDieuKien()
        {

            tbtndangnhap.Enabled = true;
            tbtnhanghoa.Enabled = true;
            tbtnhoadon.Enabled = true;
            tbtnkhachhang.Enabled = true;
            tbtnnhanvien.Enabled = true;
        }
            

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            tbtndangnhap_Click_1(sender,e);

        }    
      
        private void tbtndangnhap_Click_1(object sender, EventArgs e)
        {
            if (tbtndangnhap.Text == "Đăng nhập" && this.lbltaikhoan.Text == "")
            {
                FrmDangNhap dn = new FrmDangNhap();
                // chỉ 1 cửa sổ được mở ra!
                dn.ShowDialog();

                // nếu chuỗi có giá trị!
                if (!string.IsNullOrEmpty(TaiKhoan))
                {
                    this.lbltaikhoan.Text = TaiKhoan;
                    MoDieuKien();
                    tbtndangnhap.Text = "Đăng xuất";
                }
            }
            else
            {

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    KhoaDieuKien();
                    this.lbltaikhoan.Text = "";
                    tbtndangnhap.Text = "Đăng nhập";
                }

                if (this.lbltaikhoan.Text == "")
                {
                    KhoaDieuKien();
                    tbtndangnhap.Text = "Đăng nhập";
                }

            }
        }

        private void tbtnhotro_Click_1(object sender, EventArgs e)
        {

            FrmHT ht = new FrmHT();
            ht.ShowDialog();
        }

        private void tbtnhoadon_Click(object sender, EventArgs e)
        {

            FrmHoaDon hd = new FrmHoaDon();
            hd.ShowDialog();
        }

        private void tbtnkhachhang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowDialog();
        }

        private void tbtnhanghoa_Click(object sender, EventArgs e)
        {
            FrmHang h = new FrmHang();
            h.ShowDialog();
        }
        private void tbtnnhanvien_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.ShowDialog();
        }
        private void tbtnthoat_Click_1(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát chương trình?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

  
    }
}
