namespace QLShopHoa
{
    partial class InHoaDon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 74);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1245, 582);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_in
            // 
            this.btn_in.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Appearance.Options.UseFont = true;
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(530, 15);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(87, 50);
            this.btn_in.TabIndex = 60;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 656);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InHoaDon";
            this.Text = "In Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.SimpleButton btn_in;
    }
}