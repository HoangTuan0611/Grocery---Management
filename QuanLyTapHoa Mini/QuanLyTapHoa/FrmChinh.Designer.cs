namespace QuanLyTapHoa
{
    partial class FrmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinh));
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtndangnhap = new System.Windows.Forms.ToolStripButton();
            this.tbtnhanghoa = new System.Windows.Forms.ToolStripButton();
            this.tbtnkhachhang = new System.Windows.Forms.ToolStripButton();
            this.tbtnhoadon = new System.Windows.Forms.ToolStripButton();
            this.tbtnhotro = new System.Windows.Forms.ToolStripButton();
            this.tbtnthoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnnhanvien = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(117, 422);
            this.lbltaikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(0, 13);
            this.lbltaikhoan.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tài khoản người dùng:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtndangnhap,
            this.tbtnhanghoa,
            this.tbtnnhanvien,
            this.tbtnkhachhang,
            this.tbtnhoadon,
            this.tbtnhotro,
            this.tbtnthoat,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "Đăng Nhập";
            // 
            // tbtndangnhap
            // 
            this.tbtndangnhap.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("tbtndangnhap.Image")));
            this.tbtndangnhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtndangnhap.Name = "tbtndangnhap";
            this.tbtndangnhap.Size = new System.Drawing.Size(109, 24);
            this.tbtndangnhap.Text = "Đăng nhập";
            this.tbtndangnhap.Click += new System.EventHandler(this.tbtndangnhap_Click_1);
            // 
            // tbtnhanghoa
            // 
            this.tbtnhanghoa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnhanghoa.Image = ((System.Drawing.Image)(resources.GetObject("tbtnhanghoa.Image")));
            this.tbtnhanghoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnhanghoa.Name = "tbtnhanghoa";
            this.tbtnhanghoa.Size = new System.Drawing.Size(100, 24);
            this.tbtnhanghoa.Text = "Hàng hóa";
            this.tbtnhanghoa.Click += new System.EventHandler(this.tbtnhanghoa_Click);
            // 
            // tbtnkhachhang
            // 
            this.tbtnkhachhang.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("tbtnkhachhang.Image")));
            this.tbtnkhachhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnkhachhang.Name = "tbtnkhachhang";
            this.tbtnkhachhang.Size = new System.Drawing.Size(114, 24);
            this.tbtnkhachhang.Text = "Khách hàng";
            this.tbtnkhachhang.Click += new System.EventHandler(this.tbtnkhachhang_Click);
            // 
            // tbtnhoadon
            // 
            this.tbtnhoadon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnhoadon.Image = ((System.Drawing.Image)(resources.GetObject("tbtnhoadon.Image")));
            this.tbtnhoadon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnhoadon.Name = "tbtnhoadon";
            this.tbtnhoadon.Size = new System.Drawing.Size(92, 24);
            this.tbtnhoadon.Text = "Hóa đơn";
            this.tbtnhoadon.Click += new System.EventHandler(this.tbtnhoadon_Click);
            // 
            // tbtnhotro
            // 
            this.tbtnhotro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnhotro.Image = ((System.Drawing.Image)(resources.GetObject("tbtnhotro.Image")));
            this.tbtnhotro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnhotro.Name = "tbtnhotro";
            this.tbtnhotro.Size = new System.Drawing.Size(77, 24);
            this.tbtnhotro.Text = "Hỗ trợ";
            this.tbtnhotro.Click += new System.EventHandler(this.tbtnhotro_Click_1);
            // 
            // tbtnthoat
            // 
            this.tbtnthoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnthoat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnthoat.Image = ((System.Drawing.Image)(resources.GetObject("tbtnthoat.Image")));
            this.tbtnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnthoat.Name = "tbtnthoat";
            this.tbtnthoat.Size = new System.Drawing.Size(72, 24);
            this.tbtnthoat.Text = "Thoát";
            this.tbtnthoat.Click += new System.EventHandler(this.tbtnthoat_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbtnnhanvien
            // 
            this.tbtnnhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("tbtnnhanvien.Image")));
            this.tbtnnhanvien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnnhanvien.Name = "tbtnnhanvien";
            this.tbtnnhanvien.Size = new System.Drawing.Size(106, 24);
            this.tbtnnhanvien.Text = "Nhân Viên";
            this.tbtnnhanvien.Click += new System.EventHandler(this.tbtnnhanvien_Click);
            // 
            // FrmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._14624;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChinh";
            this.Text = "Quản lý cửa hàng tạp hóa mini";
            this.Load += new System.EventHandler(this.FrmChinh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtndangnhap;
        private System.Windows.Forms.ToolStripButton tbtnhanghoa;
        private System.Windows.Forms.ToolStripButton tbtnkhachhang;
        private System.Windows.Forms.ToolStripButton tbtnhoadon;
        private System.Windows.Forms.ToolStripButton tbtnhotro;
        private System.Windows.Forms.ToolStripButton tbtnthoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnnhanvien;
    }
}