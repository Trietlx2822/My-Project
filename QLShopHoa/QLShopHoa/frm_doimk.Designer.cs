namespace QLShopHoa
{
    partial class frm_doimk
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_doimk = new DevExpress.XtraEditors.SimpleButton();
            this.txt_nhaplaimk = new System.Windows.Forms.TextBox();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(496, 412);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 22);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng Nhập Ngay !";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(572, 315);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(113, 62);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_doimk
            // 
            this.btn_doimk.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doimk.Appearance.Options.UseFont = true;
            this.btn_doimk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_doimk.Location = new System.Drawing.Point(391, 315);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(145, 62);
            this.btn_doimk.TabIndex = 16;
            this.btn_doimk.Text = "Đổi Mật Khẩu";
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // txt_nhaplaimk
            // 
            this.txt_nhaplaimk.Location = new System.Drawing.Point(434, 251);
            this.txt_nhaplaimk.Name = "txt_nhaplaimk";
            this.txt_nhaplaimk.PasswordChar = '*';
            this.txt_nhaplaimk.Size = new System.Drawing.Size(251, 22);
            this.txt_nhaplaimk.TabIndex = 15;
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(434, 190);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(251, 22);
            this.txt_mkmoi.TabIndex = 14;
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(434, 133);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.PasswordChar = '*';
            this.txt_mkcu.Size = new System.Drawing.Size(251, 22);
            this.txt_mkcu.TabIndex = 13;
            // 
            // txt_tendn
            // 
            this.txt_tendn.Location = new System.Drawing.Point(434, 82);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(251, 22);
            this.txt_tendn.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(265, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(265, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(265, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mật Khẩu Củ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(265, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frm_doimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 514);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.txt_nhaplaimk);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_doimk";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frm_doimk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_doimk;
        private System.Windows.Forms.TextBox txt_nhaplaimk;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.TextBox txt_mkcu;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
    }
}