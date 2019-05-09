using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTapHoaEmtity;
using QuanLyTapHoaDAL;
using QuanLyTapHoaBUS;
using System.Data.SqlClient;

namespace QuanLyTapHoa
{
    public partial class FrmHang : Form
    {
        public FrmHang()
        {
            InitializeComponent();
        }
      
        KetNoiDB db = new KetNoiDB();
       
        bool themmoi;
        void KhoaDieuKien()
        {
            txtmah.Enabled = false;
            txttenh.Enabled = false;
            txtdgh.Enabled = false;
            txtmt.Enabled = false;
            txtnsx.Enabled = false;

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }



        void MoDieuKien()
        {
            txtmah.Enabled = false;
            txttenh.Enabled = true;
            txtdgh.Enabled = true;
            txtmt.Enabled = true;
            txtnsx.Enabled = true;


            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        void setnull()
        {

            txtmah.Text = "";
            txttenh.Text = "";
            txtdgh.Text = "";
            txtmt.Text = "";
            txtnsx.Text = "";
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
            // msds.DataSource = bus.TaoBang(where);
            msds.DataSource = bus.TaoBang(where);
        }
        BUS_tblHang bus = new BUS_tblHang();
        EC_tblHang ec = new EC_tblHang();

        private void FrmHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
        }

       

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            KhoaDieuKien();
            try
            {
                int dong = e.RowIndex;
                txtmah.Text = msds.Rows[dong].Cells[0].Value.ToString();
                txttenh.Text = msds.Rows[dong].Cells[1].Value.ToString();
                txtdgh.Text = msds.Rows[dong].Cells[2].Value.ToString();
                txtmt.Text = msds.Rows[dong].Cells[3].Value.ToString();
                txtnsx.Text = msds.Rows[dong].Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            try
            {
                ec.MaHang =txtmah.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Đã Xoá Thành Công", "Thông Báo");
                KhoaDieuKien();
                setnull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không Thể Xoá!", "Thông Báo");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
           
            MoDieuKien();
            setnull();
            themmoi = true;
            btnhuy.Enabled = true;
            MaTuTang();
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (txtmah.Text == "" || txttenh.Text == "")
            {
                MessageBox.Show("Xin Mời Nhập Đầy Đủ Thông Tin!", "Thông Báo");
                return;
            }

            if (themmoi == true)
            {
                try
                {

                    ec.MaHang = txtmah.Text;
                    ec.TenHang = txttenh.Text;
                    ec.DonGiaHang = txtdgh.Text;
                    ec.NhaSX = txtmt.Text;
                    ec.MoTa = txtnsx.Text;
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Đã Thêm Mới Thành Công!", "Thông Báo");

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
                    ec.MaHang = txtmah.Text;
                    ec.TenHang = txttenh.Text;
                    ec.DonGiaHang = txtdgh.Text;
                    ec.NhaSX = txtmt.Text;
                    ec.MoTa = txtnsx.Text;
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

        private void btnsua_Click_1(object sender, EventArgs e)
        {

            MoDieuKien();
            txtmah.Enabled = false;
            btnhuy.Enabled = true;
            themmoi = false;
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from tblHang");
            string h = "";
           
            if (dt.Rows.Count <= 0)
            {
                h = "HH00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã hàng đã có
                h = "HH";//ký tự mặc định của mã hàng
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)
                
                    h = h + "0000";
                else if(k<100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();
                
            }
            txtmah.Text = h;
        }

        private void txtdgh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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
                string filter = "MaHang='" + txtmah.Text + "'";
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
                row[4] = rows[i].ItemArray[4].ToString();

                tbl.Rows.Add(row);
            }
            msds.DataSource = tbl;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
