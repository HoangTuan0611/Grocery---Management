namespace QuanLyTapHoa
{
    partial class FrmNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cblocnv = new System.Windows.Forms.CheckBox();
            this.txtdcnv = new System.Windows.Forms.TextBox();
            this.labdcnv = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.labtennv = new System.Windows.Forms.Label();
            this.txtdtnv = new System.Windows.Forms.TextBox();
            this.labdtnv = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.labmanv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanVienTableAdapter = new QuanLyTapHoa.DataQLTHDataSetTableAdapters.tblNhanVienTableAdapter();
            this.dataQLTHDataSet = new QuanLyTapHoa.DataQLTHDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._2144;
            this.panel1.Controls.Add(this.cblocnv);
            this.panel1.Controls.Add(this.txtdcnv);
            this.panel1.Controls.Add(this.labdcnv);
            this.panel1.Controls.Add(this.txttennv);
            this.panel1.Controls.Add(this.labtennv);
            this.panel1.Controls.Add(this.txtdtnv);
            this.panel1.Controls.Add(this.labdtnv);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Controls.Add(this.labmanv);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cblocnv
            // 
            this.cblocnv.AutoSize = true;
            this.cblocnv.ForeColor = System.Drawing.Color.Orange;
            this.cblocnv.Location = new System.Drawing.Point(649, 106);
            this.cblocnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cblocnv.Name = "cblocnv";
            this.cblocnv.Size = new System.Drawing.Size(174, 21);
            this.cblocnv.TabIndex = 8;
            this.cblocnv.Text = "Lọc theo mã nhân viên";
            this.cblocnv.UseVisualStyleBackColor = true;
            this.cblocnv.CheckedChanged += new System.EventHandler(this.cblocnv_CheckedChanged);
            // 
            // txtdcnv
            // 
            this.txtdcnv.Location = new System.Drawing.Point(649, 68);
            this.txtdcnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdcnv.Name = "txtdcnv";
            this.txtdcnv.Size = new System.Drawing.Size(340, 22);
            this.txtdcnv.TabIndex = 7;
            // 
            // labdcnv
            // 
            this.labdcnv.AutoSize = true;
            this.labdcnv.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdcnv.Location = new System.Drawing.Point(535, 68);
            this.labdcnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labdcnv.Name = "labdcnv";
            this.labdcnv.Size = new System.Drawing.Size(71, 25);
            this.labdcnv.TabIndex = 6;
            this.labdcnv.Text = "Địa chỉ";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(156, 70);
            this.txttennv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(340, 22);
            this.txttennv.TabIndex = 5;
            // 
            // labtennv
            // 
            this.labtennv.AutoSize = true;
            this.labtennv.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtennv.Location = new System.Drawing.Point(13, 68);
            this.labtennv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labtennv.Name = "labtennv";
            this.labtennv.Size = new System.Drawing.Size(140, 25);
            this.labtennv.TabIndex = 4;
            this.labtennv.Text = "Tên nhân viên: ";
            this.labtennv.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtdtnv
            // 
            this.txtdtnv.Location = new System.Drawing.Point(649, 15);
            this.txtdtnv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdtnv.Name = "txtdtnv";
            this.txtdtnv.Size = new System.Drawing.Size(340, 22);
            this.txtdtnv.TabIndex = 6;
            this.txtdtnv.TextChanged += new System.EventHandler(this.txtdtnv_TextChanged);
            this.txtdtnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdtnv_KeyPress_1);
            // 
            // labdtnv
            // 
            this.labdtnv.AutoSize = true;
            this.labdtnv.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdtnv.Location = new System.Drawing.Point(535, 12);
            this.labdtnv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labdtnv.Name = "labdtnv";
            this.labdtnv.Size = new System.Drawing.Size(101, 25);
            this.labdtnv.TabIndex = 2;
            this.labdtnv.Text = "Điện thoại";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(156, 12);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(340, 22);
            this.txtmanv.TabIndex = 1;
            // 
            // labmanv
            // 
            this.labmanv.AutoSize = true;
            this.labmanv.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmanv.Location = new System.Drawing.Point(13, 12);
            this.labmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labmanv.Name = "labmanv";
            this.labmanv.Size = new System.Drawing.Size(139, 25);
            this.labmanv.TabIndex = 0;
            this.labmanv.Text = "Mã nhân viên: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Location = new System.Drawing.Point(4, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 49);
            this.panel2.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(891, 4);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 41);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(711, 5);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(125, 41);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(541, 4);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(125, 41);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(397, 5);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(125, 41);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(241, 4);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(125, 41);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(61, 4);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(125, 41);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvnhanvien.Location = new System.Drawing.Point(4, 194);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(1076, 359);
            this.dgvnhanvien.TabIndex = 4;
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Điện thoại";
            this.Column4.Name = "Column4";
            // 
            // tblNhanVienBindingSource
            // 
            this.tblNhanVienBindingSource.DataMember = "tblNhanVien";
            // 
            // tblNhanVienTableAdapter
            // 
            this.tblNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // dataQLTHDataSet
            // 
            this.dataQLTHDataSet.DataSetName = "DataQLTHDataSet";
            this.dataQLTHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataQLTHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label labmanv;
        private System.Windows.Forms.TextBox txtdcnv;
        private System.Windows.Forms.Label labdcnv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label labtennv;
        private System.Windows.Forms.TextBox txtdtnv;
        private System.Windows.Forms.Label labdtnv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.CheckBox cblocnv;
        private DataQLTHDataSetTableAdapters.tblNhanVienTableAdapter tblNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
        private DataQLTHDataSet dataQLTHDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}