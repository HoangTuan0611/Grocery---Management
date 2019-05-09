using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTapHoaBUS;
using QuanLyTapHoaDAL;
using QuanLyTapHoaEmtity;
namespace QuanLyTapHoa
{
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_tblKhachHang bus = new BUS_tblKhachHang();
        EC_tblKhachHang ec = new EC_tblKhachHang();
        bool themmoi;
        void KhoaDieuKien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdckh.Enabled = false;
            txtdtkh.Enabled = false;


            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
        }



        void MoDieuKien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = true;
            txtdckh.Enabled = true;
            txtdtkh.Enabled = true;


            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;          
        }

        void setnull()
        {

            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdckh.Text = "";
            txtdtkh.Text = "";
        }
        void setButton(bool val)
        {
            btnthem.Enabled = val;
            btnxoa.Enabled = val;
            btnsua.Enabled = val;
            btnthoat.Enabled = val;
            btnluu.Enabled = !val;
            btnhuy.Enabled = !val;
        }
        void HienThi(string where)
        {
            msds.DataSource = bus.TaoBang(where);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            setnull();
            themmoi = true;
            btnhuy.Enabled = true;
            MaTuTang();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {   if(txtmakh.Text ==""||txttenkh.Text=="")
            {
                MessageBox.Show("Xin Mời Nhập Đầy Đủ Thông Tin!", "Thông Báo");
                return;
            }

            if(themmoi == true)
            {
                try {

                    ec.MaKH = txtmakh.Text;
                    ec.TenKH = txttenkh.Text;
                    ec.DiaChi = txtdckh.Text;
                    ec.DienThoai = txtdtkh.Text;
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Đã Thêm Mới Thành Công!","Thông Báo");

                   }
                catch
                {
                    MessageBox.Show("lỗi!", "Thông Báo");
                    return;
                }
            }

            else
            {

                try
                {
                    ec.MaKH = txtmakh.Text;
                    ec.TenKH = txttenkh.Text;
                    ec.DiaChi = txtdckh.Text;
                    ec.DienThoai = txtdtkh.Text;
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Đã Sửa Thành Công!", "Thông Báo");                    
                }
                catch
                {
                    MessageBox.Show("lỗi!", "Thông Báo");
                    return;
                }
            }
            setnull();
            KhoaDieuKien();
            HienThi("");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaKH = txtmakh.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Đã Xoá Thành Công", "Thông Báo");
                KhoaDieuKien();
                setnull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không Thể Xoá!","Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            txtmakh.Enabled = false;
            btnhuy.Enabled = true;
            themmoi = false;
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKien();
            try
            {
                int dong = e.RowIndex;
                txtmakh.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txttenkh.Text = msds.Rows[dong].Cells[1].Value.ToString();
                txtdckh.Text = msds.Rows[dong].Cells[2].Value.ToString();
                txtdtkh.Text = msds.Rows[dong].Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void i(object sender, ControlEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from tblKhachHang");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "KH00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã Khách hàng đã có
                h = "KH";//ký tự mặc định của mã khách hàng
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            txtmakh.Text = h;
        }

        private void txtdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (themmoi == true)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn Có Muốn Huỷ Thêm Mới?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    setButton(true);
                    KhoaDieuKien();
                }
            }
            else
            {


                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn Có Muốn Huỷ Sửa?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    setButton(true);
                    KhoaDieuKien();
                }
            }
        }

        private void cbloc_CheckedChanged(object sender, EventArgs e)
        {

            if (cbloc.Checked == true)
            {
                string filter = "MaKH='" + txtmakh.Text + "'";
                kiemtratontai((DataTable)this.msds.DataSource, filter);
            }
            else
            {
                HienThi("");
            }
        }
        private void kiemtratontai(DataTable tbl, string filterExpression)
        {
            if (filterExpression == "")
            {
                return;
            }
            DataRow[] rows = tbl.Select(filterExpression);
            if (rows.Length <= 0)
            {
                return;
            }
            //lọc dữ liệu tìm được ra msds( cái dataGridView)
            tbl = ((DataTable)this.msds.DataSource).Clone();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = tbl.NewRow();
                row[0] = rows[i].ItemArray[0].ToString();
                row[1] = rows[i].ItemArray[1].ToString();
                row[2] = rows[i].ItemArray[2].ToString();
                row[3] = rows[i].ItemArray[3].ToString();               
                tbl.Rows.Add(row);
            }
            msds.DataSource = tbl;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdtkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
