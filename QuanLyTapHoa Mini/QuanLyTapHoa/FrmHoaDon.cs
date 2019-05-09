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
using QuanLyTapHoaEmtity;
using QuanLyTapHoaDAL;

using System.Data.SqlClient;
namespace QuanLyTapHoa
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_tblHoaDon bushd = new BUS_tblHoaDon();
        BUS_tblCTHD buscthd = new BUS_tblCTHD();    
        EC_tblHoaDon HD = new EC_tblHoaDon();
        EC_tblCTHD CTHD = new EC_tblCTHD();

        
        int dong = 0;
        bool themmoi;
        void KhoaDieuKien()
        {
            txtmahd.Enabled = false;
            cbmkh.Enabled = false;
            cbmnv.Enabled = false;
           


            btnthem.Enabled = true;
            btnluu.Enabled = false;
            
            btnxoa.Enabled = true;
        }



        void MoDieuKien()
        {
            txtmahd.Enabled = false;
            cbmkh.Enabled = true;
            cbmnv.Enabled = true;
            

            btnthem.Enabled = false;
            btnluu.Enabled = true;
            
            btnxoa.Enabled = false;
        }

        void setnull()
        {

            txtmahd.Text = "";
            cbmkh.Text = "";
            cbmnv.Text = "";
            
        }
        
       
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();          
            colmah.DataSource = buscthd.LayThongTinMH("");
            colmah.ValueMember = "Mahang";
            colmah.DisplayMember = "TenHang";
            cbmkh.DataSource = bushd.LayThongTinKH("");
            // cbmkh.DisplayMember = "TenKH";
            //cbmkh.ValueMember = "MaKH";
            cbmkh.ValueMember = "MaKH";
            cbmkh.DisplayMember = "MaKH";
            cbmnv.DataSource = bushd.LayThongTinNV("");
            cbmnv.ValueMember = "MaNV";
            cbmnv.DisplayMember = "MaNV";
        }

    private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //click vao dong dang kick
            dong = e.RowIndex;

        }
        //thao tac tren luoi roi moi co su kien (giong qua khu)!
        private void msds_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (msds.Rows[dong].Cells[1].Value != "0" && msds.Rows[dong].Cells[2].Value !="0")
            {
                try
                {
                    string a= (double.Parse(msds.Rows[dong].Cells[1].Value.ToString()) * double.Parse(msds.Rows[dong].Cells[2].Value.ToString())).ToString();
                   // msds.Rows[dong].Cells[3].Value = (double.Parse(msds.Rows[dong].Cells[1].Value.ToString()) * double.Parse(msds.Rows[dong].Cells[2].Value.ToString())).ToString();
                    msds.Rows[dong].Cells[3].Value = a;
                }
                catch
                {

                }

            }
            try
            {
                DataTable dt = new DataTable();
                dt = buscthd.LayThongTinMH("where MaHang = '"+msds.Rows[dong].Cells[0].Value.ToString()+"'");
                msds.Rows[dong].Cells[2].Value = double.Parse( dt.Rows[0]["DonGiaHang"].ToString()).ToString();

            }
            catch
            {

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
           
            if (txtmahd.Text == "" || cbmkh.Text == ""||cbmnv.Text=="")
            {
                MessageBox.Show("Xin Mời Nhập Đầy Đủ Thông Tin!", "Thông Báo");
                return;
            }

            if (themmoi == true)
            {
                try
                {

                    HD.MaHD = txtmahd.Text;
                    HD.MaKH = cbmkh.SelectedValue.ToString();
                    HD.MaNV = cbmnv.SelectedValue.ToString();
                    HD.NgayLap = txtngaylap.Text;

                    CTHD.MaHD = txtmahd.Text;
                    CTHD.MaHang = colmah.ToString();
                    CTHD.SoLuongMua = colslm.ToString();
                    CTHD.DonGiaBan = coldgb.ToString();
                    CTHD.ThanhTien = Coltt.ToString();

                    buscthd.ThemDuLieu(CTHD);
                    bushd.ThemDuLieu(HD);
                   

                }
                catch
                {
                    MessageBox.Show("lỗi!", "Thông Báo");
                    return;
                }
            }

            //else
            //{

            //    try
            //    {

            //        HD.MaHD = txtmahd.Text;
            //        HD.MaKH = cbmkh.SelectedValue.ToString();
            //        HD.MaNV = cbmnv.SelectedValue.ToString();
            //        HD.NgayLap = txtngaylap.Text;
            //        bushd.SuaDuLieu(HD);
                   
            //    }
            //    catch
            //    {
            //        MessageBox.Show("lỗi!", "Thông Báo");
            //        return;
            //    }
            //}
            /*  try
              {
                  HD.MaHD = txtmahd.Text;
                  HD.MaKH = "KH01";
                  HD.NgayLap = txtngaylap.Text;
                  HD.MaNV = "NV01";
                  bushd.ThemDuLieu(HD);
              }
              catch { MessageBox.Show("lỗi!", "Thông Báo"); }*/
            //try
            //{
            //    for(int i=0;i < msds.Rows.Count - 1;i++)
            //    {
            //        CTHD.MaHD = txtmahd.Text;
            //        CTHD.MaHang = msds.Rows[i].Cells[0].Value.ToString();
            //        CTHD.SoLuongMua= msds.Rows[i].Cells[1].Value.ToString();
            //        CTHD.DonGiaBan = msds.Rows[i].Cells[2].Value.ToString();
            //        buscthd.ThemDuLieu(CTHD);                   
                   
            //        busrpcthd.ThemDuLieu(CTHD);
            //    }
            //// MessageBox.Show("Đã Tạo Hoá Đơn Thành Công!","Thông Báo");
            //    DialogResult thongbao;
            //    thongbao = (MessageBox.Show("Bạn có muốn In Hoá Đơn Không?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            //    if (thongbao == DialogResult.Yes)
            //    {
            //        FrmRPCTHD rp = new FrmRPCTHD();
            //        rp.ShowDialog();
            //    }
            //}
            //catch { }

           
            // Để hiện thị ra Hoá Đơn!
            setnull();
            KhoaDieuKien();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // chỉ thao tác xoá được khi mà hoá đơn vừa lưu xong!
            try
            {

                bushd.XoaDuLieu(HD);
                buscthd.XoaDuLieu(CTHD);
                MessageBox.Show("Đã Xoá Thành Công", "Thông Báo");
               
            }
            catch
            {
                MessageBox.Show("Không Thể Xoá!", "Thông Báo");
            }
           
            //Để hiện thị ra Hoá Đơn 
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmahd.Enabled = false;
            themmoi = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            setnull();
            msds.Rows.Clear();
            themmoi = true;         
            MaTuTang();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from tblHoaDon");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "HD00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã hoá đơn đã có
                h = "HD";//ký tự mặc định của mã hoá đơn
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
            txtmahd.Text = h;
        }
       /* class ExportToExcel
        {
            public void Export(DataTable db, string sheetName, string title)
            {

                //Tạo các đối tượng Excel

                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần đầu nếu muốn

                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "C1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Tahoma";

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã Hàng";

                cl1.ColumnWidth = 13.5;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Số lượng";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Đơn giá bán";

                cl3.ColumnWidth = 40.0;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "D4");

                rowHead.Font.Bold = true;
                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D4", "D4");

                cl4.Value2 = "Thành Tiền";

                cl4.ColumnWidth = 40.0;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 15;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

                // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

                object[,] arr = new object[db.Rows.Count, db.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int r = 0; r < db.Rows.Count; r++)

                {

                    DataRow dr = db.Rows[r];

                    for (int c = 0; c < db.Columns.Count; c++)

                    {
                        arr[r, c] = dr[c];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + db.Rows.Count - 1;

                int columnEnd = db.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột STT

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
        }*/
    
    private void btnExcel_Click(object sender, EventArgs e)
        {
           // ExportToExcel  excel = new ExportToExcel();
            //DataTable da = (DataTable)msds.DataSource;
            //excel.Export(da, "Danh sach", "DANH SÁCH CÁC HÓA ĐƠN");
        }



        //private void btnxuatcthd_Click(object sender, EventArgs e)
        //{
        //    FrmRPCTHD rp = new FrmRPCTHD();

        //}
    }
}
