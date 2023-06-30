namespace QLShopHoa
{
    partial class frm_saoluu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_duongdan = new System.Windows.Forms.TextBox();
            this.txt_teptin = new System.Windows.Forms.TextBox();
            this.btn_chon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dongy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sao Lưu Dữ Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường Dẫn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tệp Tin";
            // 
            // txt_duongdan
            // 
            this.txt_duongdan.Location = new System.Drawing.Point(281, 100);
            this.txt_duongdan.Name = "txt_duongdan";
            this.txt_duongdan.Size = new System.Drawing.Size(268, 30);
            this.txt_duongdan.TabIndex = 1;
            // 
            // txt_teptin
            // 
            this.txt_teptin.Location = new System.Drawing.Point(281, 176);
            this.txt_teptin.Name = "txt_teptin";
            this.txt_teptin.Size = new System.Drawing.Size(268, 30);
            this.txt_teptin.TabIndex = 1;
            // 
            // btn_chon
            // 
            this.btn_chon.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chon.Appearance.Options.UseFont = true;
            this.btn_chon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_chon.Location = new System.Drawing.Point(565, 95);
            this.btn_chon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(82, 37);
            this.btn_chon.TabIndex = 15;
            this.btn_chon.Text = "Chọn...";
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_dongy
            // 
            this.btn_dongy.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongy.Appearance.Options.UseFont = true;
            this.btn_dongy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_dongy.Location = new System.Drawing.Point(290, 248);
            this.btn_dongy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(101, 48);
            this.btn_dongy.TabIndex = 15;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(419, 248);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(101, 48);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_saoluu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 347);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.txt_teptin);
            this.Controls.Add(this.txt_duongdan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_saoluu";
            this.Text = "SAO LƯU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_duongdan;
        private System.Windows.Forms.TextBox txt_teptin;
        private DevExpress.XtraEditors.SimpleButton btn_chon;
        private DevExpress.XtraEditors.SimpleButton btn_dongy;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}