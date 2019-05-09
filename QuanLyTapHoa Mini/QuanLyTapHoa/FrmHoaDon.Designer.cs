namespace QuanLyTapHoa
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmnv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmkh = new System.Windows.Forms.ComboBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.txtngaylap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msds = new System.Windows.Forms.DataGridView();
            this.colmah = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colslm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldgb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._2144;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmnv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbmkh);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.txtngaylap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Location = new System.Drawing.Point(1, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 56);
            this.panel2.TabIndex = 10;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(437, 10);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 36);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(322, 10);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 36);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(196, 9);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 36);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(9, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(166, 36);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Hoá Đơn Mới";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(446, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày Lập:";
            // 
            // cbmnv
            // 
            this.cbmnv.FormattingEnabled = true;
            this.cbmnv.Location = new System.Drawing.Point(626, 20);
            this.cbmnv.Name = "cbmnv";
            this.cbmnv.Size = new System.Drawing.Size(207, 28);
            this.cbmnv.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã nhân viên lập:";
            // 
            // cbmkh
            // 
            this.cbmkh.FormattingEnabled = true;
            this.cbmkh.Location = new System.Drawing.Point(186, 58);
            this.cbmkh.Name = "cbmkh";
            this.cbmkh.Size = new System.Drawing.Size(207, 28);
            this.cbmkh.TabIndex = 8;
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(186, 21);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(207, 28);
            this.txtmahd.TabIndex = 5;
            // 
            // txtngaylap
            // 
            this.txtngaylap.CustomFormat = "";
            this.txtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngaylap.Location = new System.Drawing.Point(626, 58);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(111, 28);
            this.txtngaylap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msds);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1071, 357);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmah,
            this.colslm,
            this.coldgb,
            this.Coltt});
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(3, 28);
            this.msds.Name = "msds";
            this.msds.RowTemplate.Height = 24;
            this.msds.Size = new System.Drawing.Size(1065, 326);
            this.msds.TabIndex = 0;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            this.msds.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellValueChanged);
            // 
            // colmah
            // 
            this.colmah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmah.DataPropertyName = "MaHang";
            this.colmah.HeaderText = "Mã Hàng";
            this.colmah.Name = "colmah";
            // 
            // colslm
            // 
            this.colslm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colslm.DataPropertyName = "SoLuongMua";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.colslm.DefaultCellStyle = dataGridViewCellStyle1;
            this.colslm.HeaderText = "Số lượng Mua";
            this.colslm.Name = "colslm";
            // 
            // coldgb
            // 
            this.coldgb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldgb.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.coldgb.DefaultCellStyle = dataGridViewCellStyle2;
            this.coldgb.HeaderText = "Đơn Giá Bán";
            this.coldgb.Name = "coldgb";
            // 
            // Coltt
            // 
            this.Coltt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coltt.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Coltt.DefaultCellStyle = dataGridViewCellStyle3;
            this.Coltt.HeaderText = "Thành Tiền";
            this.Coltt.Name = "Coltt";
            this.Coltt.ReadOnly = true;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmkh;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.DateTimePicker txtngaylap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridViewComboBoxColumn colmah;
        private System.Windows.Forms.DataGridViewTextBoxColumn colslm;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltt;
        private System.Windows.Forms.ComboBox cbmnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}