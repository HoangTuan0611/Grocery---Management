namespace QuanLyTapHoa
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttnd = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.Label();
            this.btndn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(140, 86);
            this.txtmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(293, 22);
            this.txtmk.TabIndex = 12;
            this.txtmk.UseWaitCursor = true;
            this.txtmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmk_KeyDown);
            // 
            // txttnd
            // 
            this.txttnd.Location = new System.Drawing.Point(140, 44);
            this.txttnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttnd.Name = "txttnd";
            this.txttnd.Size = new System.Drawing.Size(293, 22);
            this.txttnd.TabIndex = 11;
            this.txttnd.UseWaitCursor = true;
            this.txttnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttnd_KeyDown);
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.BackColor = System.Drawing.Color.Transparent;
            this.matkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(57, 90);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(78, 20);
            this.matkhau.TabIndex = 8;
            this.matkhau.Text = "Mật khẩu:";
            this.matkhau.UseWaitCursor = true;
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.taikhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.Location = new System.Drawing.Point(53, 48);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(79, 20);
            this.taikhoan.TabIndex = 7;
            this.taikhoan.Text = "Tài khoản:";
            this.taikhoan.UseWaitCursor = true;
            // 
            // btndn
            // 
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndn.ImageKey = "(none)";
            this.btndn.Location = new System.Drawing.Point(220, 166);
            this.btndn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(117, 36);
            this.btndn.TabIndex = 13;
            this.btndn.Text = "Đăng nhập";
            this.btndn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mặc định: Tài khoản/Mật khẩu là admin/admin";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(343, 166);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(92, 36);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTapHoa.Properties.Resources._14624;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttnd);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDangNhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttnd;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
    }
}