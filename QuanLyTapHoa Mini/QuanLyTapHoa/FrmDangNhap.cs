using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTapHoaDAL;
using Microsoft.ApplicationBlocks.Data;
namespace QuanLyTapHoa
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        private void btndn_Click(object sender, EventArgs e)
        {
            /*
            if (this.txttnd.Text == "admin" && this.txtmk.Text == "admin")
            {

                //MessageBox.Show("Đăng Nhập Thành Công\nChào Bạn");
                // gửi giá trị qua bên frm chính
                FrmChinh.TaiKhoan = txttnd.Text;
                this.Hide();

            }*/
            string strcon = @"Data Source=DESKTOP-8I4FATD;Initial Catalog=DataQLTH;Integrated Security=SSPI;";
            string user = txttnd.Text.Trim();
            string pass = txtmk.Text.Trim();
            DataTable dt = SqlHelper.ExecuteDataset(strcon, "tblDangNhap_Login", user, pass).Tables[0];

            if (dt.Rows.Count > 0)

            {
                FrmChinh.TaiKhoan = txttnd.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu?", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txttnd.Focus();

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmChinh.TaiKhoan = txttnd.Text = "";

            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn huỷ đăng nhập?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                //MessageBox.Show("Tạm Biệt! Hẹn Gặp Lại", "Thông Báo");
                //Application.Exit();
                this.Hide();
            }
        }

        private void txtmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btndn_Click(sender, e);
            }

        }

        private void txttnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btndn_Click(sender, e);
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
