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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_tblNhanVien bus = new BUS_tblNhanVien();
        EC_tblNhanVien ec = new EC_tblNhanVien();
        bool themmoi;

        void KhoaDieuKien()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            txtdcnv.Enabled = false;
            txtdtnv.Enabled = false;

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
        }

        void MoDieuKien()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = true;
            txtdcnv.Enabled = true;
            txtdtnv.Enabled = true;

            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        void setnull()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdcnv.Text = "";
            txtdtnv.Text = "";

        }

        void setbutton(bool val)
        {
            btnthem.Enabled = val;
            btnluu.Enabled = val;
            btnhuy.Enabled = val;
            btnxoa.Enabled = val;
            btnthoat.Enabled = val;
            btnsua.Enabled = val;
        }
        void HienThi(string where)
        {
            dgvnhanvien.DataSource = bus.TaoBang(where);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhanVien_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataQLTHDataSet.tblNhanVien' table. You can move, or remove it, as needed.
            //this.tblNhanVienTableAdapter.Fill(this.dataQLTHDataSet.tblNhanVien);
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
        {
            if(txtmanv.Text==""||txttennv.Text=="")
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                return;
            }
            if(themmoi==true)
            {
                try
                {
                    ec.MaNV = txtmanv.Text;
                    ec.TenNV = txttennv.Text;
                    ec.DiaChi = txtdcnv.Text;
                    ec.DienThoai = txtdtnv.Text;
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Báo lỗi", "Thông báo");
                    return;
                }
            }
            else
            {
                try
                {
                    ec.MaNV = txtmanv.Text;
                    ec.TenNV = txttennv.Text;
                    ec.DiaChi = txtdcnv.Text;
                    ec.DienThoai = txtdtnv.Text;
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Báo lỗi", "Thông báo");
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
                ec.MaNV = txtmanv.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                KhoaDieuKien();
                setnull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không thể xóa!","Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            txtmanv.Enabled = false;
            btnhuy.Enabled = true;
            themmoi = false;
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKien();
            try
            {
                int dong = e.RowIndex;
                txtmanv.Text = dgvnhanvien.Rows[dong].Cells[0].Value.ToString();
                txttennv.Text = dgvnhanvien.Rows[dong].Cells[1].Value.ToString();
                txtdcnv.Text = dgvnhanvien.Rows[dong].Cells[2].Value.ToString();
                txtdtnv.Text = dgvnhanvien.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from tblNhanVien");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "NV00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "NV";//ký tự mặc định của mã nhân viên
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
           txtmanv.Text = h;
        }
    

        private void txtdtnv_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(themmoi==true)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn hủy thêm mới?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if(thongbao==DialogResult.Yes)
                {
                    setbutton(true);
                    KhoaDieuKien();
                }
            }
            else
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn hủy sửa?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if(thongbao==DialogResult.Yes)
                {
                    setbutton(true);
                    KhoaDieuKien();
                }
            }
        }

        private void cblocnv_CheckedChanged(object sender, EventArgs e)
        {
            if (cblocnv.Checked == true)
            {
                string filter = "MaNV='" + txtmanv.Text + "'";
                KiemTraTonTai((DataTable)this.dgvnhanvien.DataSource, filter);
            }
            else
            {
                HienThi("");
            }
        }
        private void KiemTraTonTai(DataTable tbl, string filterExpression)
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
            tbl = ((DataTable)this.dgvnhanvien.DataSource).Clone();
            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = tbl.NewRow();
                row[0] = rows[i].ItemArray[0].ToString();
                row[1] = rows[i].ItemArray[1].ToString();
                row[2] = rows[i].ItemArray[2].ToString();
                row[3] = rows[i].ItemArray[3].ToString();
                tbl.Rows.Add(row);
            }
            dgvnhanvien.DataSource = tbl;
        }

        private void txtdtnv_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}