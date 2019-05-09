namespace QuanLyTapHoa
{
    partial class FrmHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHang));
            this.msds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labmahang = new System.Windows.Forms.Label();
            this.labtenhang = new System.Windows.Forms.Label();
            this.labdgh = new System.Windows.Forms.Label();
            this.labnsx = new System.Windows.Forms.Label();
            this.txtmah = new System.Windows.Forms.TextBox();
            this.txttenh = new System.Windows.Forms.TextBox();
            this.txtdgh = new System.Windows.Forms.TextBox();
            this.txtnsx = new System.Windows.Forms.TextBox();
            this.labmota = new System.Windows.Forms.Label();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.cbloc = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msds
            // 
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(0, 185);
            this.msds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msds.Name = "msds";
            this.msds.RowTemplate.Height = 24;
            this.msds.Size = new System.Drawing.Size(1179, 309);
            this.msds.TabIndex = 5;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHang";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenHang";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DonGiaHang";
            this.Column3.HeaderText = "Đơn Giá Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NhaSX";
            this.Column4.HeaderText = "Nhà Sản Xuất";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MoTa";
            this.Column5.HeaderText = "Mô Tả";
            this.Column5.Name = "Column5";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 33);
            this.panel2.TabIndex = 4;
            // 
            // labmahang
            // 
            this.labmahang.AutoSize = true;
            this.labmahang.BackColor = System.Drawing.Color.Transparent;
            this.labmahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmahang.Location = new System.Drawing.Point(47, 20);
            this.labmahang.Name = "labmahang";
            this.labmahang.Size = new System.Drawing.Size(89, 24);
            this.labmahang.TabIndex = 0;
            this.labmahang.Text = "Mã hàng:";
            // 
            // labtenhang
            // 
            this.labtenhang.AutoSize = true;
            this.labtenhang.BackColor = System.Drawing.Color.Transparent;
            this.labtenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenhang.Location = new System.Drawing.Point(45, 63);
            this.labtenhang.Name = "labtenhang";
            this.labtenhang.Size = new System.Drawing.Size(97, 24);
            this.labtenhang.TabIndex = 1;
            this.labtenhang.Text = "Tên hàng:";
            // 
            // labdgh
            // 
            this.labdgh.AutoSize = true;
            this.labdgh.BackColor = System.Drawing.Color.Transparent;
            this.labdgh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdgh.Location = new System.Drawing.Point(421, 20);
            this.labdgh.Name = "labdgh";
            this.labdgh.Size = new System.Drawing.Size(80, 24);
            this.labdgh.TabIndex = 2;
            this.labdgh.Text = "Đơn giá:";
            // 
            // labnsx
            // 
            this.labnsx.AutoSize = true;
            this.labnsx.BackColor = System.Drawing.Color.Transparent;
            this.labnsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnsx.Location = new System.Drawing.Point(419, 63);
            this.labnsx.Name = "labnsx";
            this.labnsx.Size = new System.Drawing.Size(125, 24);
            this.labnsx.TabIndex = 3;
            this.labnsx.Text = "Nhà sản xuất:";
            // 
            // txtmah
            // 
            this.txtmah.Location = new System.Drawing.Point(143, 14);
            this.txtmah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmah.Name = "txtmah";
            this.txtmah.Size = new System.Drawing.Size(217, 29);
            this.txtmah.TabIndex = 4;
            // 
            // txttenh
            // 
            this.txttenh.Location = new System.Drawing.Point(143, 57);
            this.txttenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenh.Name = "txttenh";
            this.txttenh.Size = new System.Drawing.Size(259, 29);
            this.txttenh.TabIndex = 5;
            // 
            // txtdgh
            // 
            this.txtdgh.Location = new System.Drawing.Point(548, 14);
            this.txtdgh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdgh.Name = "txtdgh";
            this.txtdgh.Size = new System.Drawing.Size(256, 29);
            this.txtdgh.TabIndex = 6;
            this.txtdgh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdgh_KeyPress);
            // 
            // txtnsx
            // 
            this.txtnsx.Location = new System.Drawing.Point(548, 58);
            this.txtnsx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnsx.Name = "txtnsx";
            this.txtnsx.Size = new System.Drawing.Size(296, 29);
            this.txtnsx.TabIndex = 7;
            // 
            // labmota
            // 
            this.labmota.AutoSize = true;
            this.labmota.BackColor = System.Drawing.Color.Transparent;
            this.labmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmota.Location = new System.Drawing.Point(49, 106);
            this.labmota.Name = "labmota";
            this.labmota.Size = new System.Drawing.Size(61, 24);
            this.labmota.TabIndex = 8;
            this.labmota.Text = "Mô tả:";
            // 
            // txtmt
            // 
            this.txtmt.Location = new System.Drawing.Point(143, 102);
            this.txtmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmt.Name = "txtmt";
            this.txtmt.Size = new System.Drawing.Size(319, 29);
            this.txtmt.TabIndex = 9;
            // 
            // cbloc
            // 
            this.cbloc.AutoSize = true;
            this.cbloc.Location = new System.Drawing.Point(585, 109);
            this.cbloc.Name = "cbloc";
            this.cbloc.Size = new System.Drawing.Size(235, 28);
            this.cbloc.TabIndex = 10;
            this.cbloc.Text = "Lọc Theo Mã Hàng Hoá";
            this.cbloc.UseVisualStyleBackColor = true;
            this.cbloc.CheckedChanged += new System.EventHandler(this.cbloc_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._2144;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbloc);
            this.panel1.Controls.Add(this.txtmt);
            this.panel1.Controls.Add(this.labmota);
            this.panel1.Controls.Add(this.txtnsx);
            this.panel1.Controls.Add(this.txtdgh);
            this.panel1.Controls.Add(this.txttenh);
            this.panel1.Controls.Add(this.txtmah);
            this.panel1.Controls.Add(this.labnsx);
            this.panel1.Controls.Add(this.labdgh);
            this.panel1.Controls.Add(this.labtenhang);
            this.panel1.Controls.Add(this.labmahang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 152);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(487, -1);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(101, 33);
            this.btnhuy.TabIndex = 6;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(619, 0);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 32);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(51, 0);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 32);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm Mới";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(175, 0);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnluu.Size = new System.Drawing.Size(79, 32);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(279, 0);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(79, 32);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(383, 0);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 32);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // FrmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1179, 494);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHang";
            this.Text = "Hàng hóa";
            this.Load += new System.EventHandler(this.FrmHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label labmahang;
        private System.Windows.Forms.Label labtenhang;
        private System.Windows.Forms.Label labdgh;
        private System.Windows.Forms.Label labnsx;
        private System.Windows.Forms.TextBox txtmah;
        private System.Windows.Forms.TextBox txttenh;
        private System.Windows.Forms.TextBox txtdgh;
        private System.Windows.Forms.TextBox txtnsx;
        private System.Windows.Forms.Label labmota;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.CheckBox cbloc;
        private System.Windows.Forms.Panel panel1;
    }
}