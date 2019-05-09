namespace QuanLyTapHoa
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.msds = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbloc = new System.Windows.Forms.CheckBox();
            this.txtdckh = new System.Windows.Forms.TextBox();
            this.txtdtkh = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.labdckh = new System.Windows.Forms.Label();
            this.labdtkh = new System.Windows.Forms.Label();
            this.labtenkh = new System.Windows.Forms.Label();
            this.labmakh = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 29);
            this.panel2.TabIndex = 1;
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(372, 1);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(76, 27);
            this.btnhuy.TabIndex = 7;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(461, 0);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(76, 27);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(278, 0);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(63, 27);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(197, 0);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(63, 27);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(117, 0);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(62, 27);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(27, 0);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(73, 27);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // msds
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.msds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(0, 119);
            this.msds.Margin = new System.Windows.Forms.Padding(2);
            this.msds.Name = "msds";
            this.msds.RowTemplate.Height = 24;
            this.msds.Size = new System.Drawing.Size(884, 282);
            this.msds.TabIndex = 2;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            this.msds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Điện Thoại";
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._2144;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.cbloc);
            this.panel1.Controls.Add(this.txtdckh);
            this.panel1.Controls.Add(this.txtdtkh);
            this.panel1.Controls.Add(this.txttenkh);
            this.panel1.Controls.Add(this.txtmakh);
            this.panel1.Controls.Add(this.labdckh);
            this.panel1.Controls.Add(this.labdtkh);
            this.panel1.Controls.Add(this.labtenkh);
            this.panel1.Controls.Add(this.labmakh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbloc
            // 
            this.cbloc.AutoSize = true;
            this.cbloc.ForeColor = System.Drawing.Color.Orange;
            this.cbloc.Location = new System.Drawing.Point(432, 71);
            this.cbloc.Margin = new System.Windows.Forms.Padding(2);
            this.cbloc.Name = "cbloc";
            this.cbloc.Size = new System.Drawing.Size(153, 17);
            this.cbloc.TabIndex = 11;
            this.cbloc.Text = "Lọc Theo Mã Khách Hàng";
            this.cbloc.UseVisualStyleBackColor = true;
            this.cbloc.CheckedChanged += new System.EventHandler(this.cbloc_CheckedChanged);
            // 
            // txtdckh
            // 
            this.txtdckh.Location = new System.Drawing.Point(432, 49);
            this.txtdckh.Margin = new System.Windows.Forms.Padding(2);
            this.txtdckh.Name = "txtdckh";
            this.txtdckh.Size = new System.Drawing.Size(298, 20);
            this.txtdckh.TabIndex = 7;
            // 
            // txtdtkh
            // 
            this.txtdtkh.Location = new System.Drawing.Point(432, 16);
            this.txtdtkh.Margin = new System.Windows.Forms.Padding(2);
            this.txtdtkh.Name = "txtdtkh";
            this.txtdtkh.Size = new System.Drawing.Size(164, 20);
            this.txtdtkh.TabIndex = 6;
            this.txtdtkh.TextChanged += new System.EventHandler(this.txtdtkh_TextChanged);
            this.txtdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdtkh_KeyPress);
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(132, 47);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(2);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(190, 20);
            this.txttenkh.TabIndex = 5;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(132, 16);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(2);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(164, 20);
            this.txtmakh.TabIndex = 4;
            // 
            // labdckh
            // 
            this.labdckh.AutoSize = true;
            this.labdckh.BackColor = System.Drawing.Color.Transparent;
            this.labdckh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdckh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labdckh.Location = new System.Drawing.Point(348, 50);
            this.labdckh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labdckh.Name = "labdckh";
            this.labdckh.Size = new System.Drawing.Size(60, 20);
            this.labdckh.TabIndex = 3;
            this.labdckh.Text = "Địa chỉ:";
            // 
            // labdtkh
            // 
            this.labdtkh.AutoSize = true;
            this.labdtkh.BackColor = System.Drawing.Color.Transparent;
            this.labdtkh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdtkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labdtkh.Location = new System.Drawing.Point(347, 16);
            this.labdtkh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labdtkh.Name = "labdtkh";
            this.labdtkh.Size = new System.Drawing.Size(84, 20);
            this.labdtkh.TabIndex = 2;
            this.labdtkh.Text = "Điện thoại:";
            // 
            // labtenkh
            // 
            this.labtenkh.AutoSize = true;
            this.labtenkh.BackColor = System.Drawing.Color.Transparent;
            this.labtenkh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labtenkh.Location = new System.Drawing.Point(11, 47);
            this.labtenkh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labtenkh.Name = "labtenkh";
            this.labtenkh.Size = new System.Drawing.Size(121, 20);
            this.labtenkh.TabIndex = 1;
            this.labtenkh.Text = "Tên khách hàng:";
            // 
            // labmakh
            // 
            this.labmakh.AutoSize = true;
            this.labmakh.BackColor = System.Drawing.Color.Transparent;
            this.labmakh.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmakh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labmakh.Location = new System.Drawing.Point(12, 16);
            this.labmakh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labmakh.Name = "labmakh";
            this.labmakh.Size = new System.Drawing.Size(119, 20);
            this.labmakh.TabIndex = 0;
            this.labmakh.Text = "Mã khách hàng:";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 401);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKhachHang";
            this.Text = "Khách Hàng";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.i);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.TextBox txtdckh;
        private System.Windows.Forms.TextBox txtdtkh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label labdckh;
        private System.Windows.Forms.Label labdtkh;
        private System.Windows.Forms.Label labtenkh;
        private System.Windows.Forms.Label labmakh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.CheckBox cbloc;
    }
}

