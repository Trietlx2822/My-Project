namespace QLShopHoa
{
    partial class frm_thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongke));
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_doanhthu = new DevExpress.XtraGrid.GridControl();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_nam = new System.Windows.Forms.ComboBox();
            this.cmb_theothang = new System.Windows.Forms.ComboBox();
            this.date_denngay = new System.Windows.Forms.DateTimePicker();
            this.date_tungay = new System.Windows.Forms.DateTimePicker();
            this.date_theongay = new System.Windows.Forms.DateTimePicker();
            this.rdb_tungay = new System.Windows.Forms.RadioButton();
            this.rdb_theothang = new System.Windows.Forms.RadioButton();
            this.rdb_theongay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Thành Tiền";
            this.gridColumn6.FieldName = "ThanhTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Lượng";
            this.gridColumn4.FieldName = "Soluong";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Sản Phẩm";
            this.gridColumn3.FieldName = "Tensp";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã Sản Phẩm";
            this.gridColumn2.FieldName = "Masp";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số Hóa Đơn";
            this.gridColumn1.FieldName = "Sohd";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.DetailHeight = 481;
            this.gridView1.GridControl = this.grid_doanhthu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfReportFooter = resources.GetString("gridView1.OptionsPrint.RtfReportFooter");
            this.gridView1.OptionsPrint.RtfReportHeader = resources.GetString("gridView1.OptionsPrint.RtfReportHeader");
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đơn Giá";
            this.gridColumn5.FieldName = "Dongia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // grid_doanhthu
            // 
            this.grid_doanhthu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_doanhthu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_doanhthu.Location = new System.Drawing.Point(0, 497);
            this.grid_doanhthu.MainView = this.gridView1;
            this.grid_doanhthu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_doanhthu.Name = "grid_doanhthu";
            this.grid_doanhthu.Size = new System.Drawing.Size(1416, 288);
            this.grid_doanhthu.TabIndex = 21;
            this.grid_doanhthu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btn_thoat
            // 
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(881, 338);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 52);
            this.btn_thoat.TabIndex = 18;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(691, 338);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(114, 52);
            this.btn_in.TabIndex = 19;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_xem.Location = new System.Drawing.Point(487, 338);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(124, 52);
            this.btn_xem.TabIndex = 20;
            this.btn_xem.Text = "Xem Thống Kê";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(798, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đến Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(798, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Năm";
            // 
            // cmb_nam
            // 
            this.cmb_nam.FormattingEnabled = true;
            this.cmb_nam.Location = new System.Drawing.Point(907, 172);
            this.cmb_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_nam.Name = "cmb_nam";
            this.cmb_nam.Size = new System.Drawing.Size(155, 30);
            this.cmb_nam.TabIndex = 14;
            // 
            // cmb_theothang
            // 
            this.cmb_theothang.FormattingEnabled = true;
            this.cmb_theothang.Location = new System.Drawing.Point(583, 172);
            this.cmb_theothang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_theothang.Name = "cmb_theothang";
            this.cmb_theothang.Size = new System.Drawing.Size(155, 30);
            this.cmb_theothang.TabIndex = 15;
            // 
            // date_denngay
            // 
            this.date_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_denngay.Location = new System.Drawing.Point(907, 254);
            this.date_denngay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_denngay.Name = "date_denngay";
            this.date_denngay.Size = new System.Drawing.Size(155, 30);
            this.date_denngay.TabIndex = 11;
            // 
            // date_tungay
            // 
            this.date_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tungay.Location = new System.Drawing.Point(583, 254);
            this.date_tungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_tungay.Name = "date_tungay";
            this.date_tungay.Size = new System.Drawing.Size(155, 30);
            this.date_tungay.TabIndex = 12;
            // 
            // date_theongay
            // 
            this.date_theongay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_theongay.Location = new System.Drawing.Point(583, 99);
            this.date_theongay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_theongay.Name = "date_theongay";
            this.date_theongay.Size = new System.Drawing.Size(155, 30);
            this.date_theongay.TabIndex = 13;
            // 
            // rdb_tungay
            // 
            this.rdb_tungay.AutoSize = true;
            this.rdb_tungay.BackColor = System.Drawing.Color.Transparent;
            this.rdb_tungay.Location = new System.Drawing.Point(436, 254);
            this.rdb_tungay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_tungay.Name = "rdb_tungay";
            this.rdb_tungay.Size = new System.Drawing.Size(90, 26);
            this.rdb_tungay.TabIndex = 8;
            this.rdb_tungay.TabStop = true;
            this.rdb_tungay.Text = "Từ Ngày";
            this.rdb_tungay.UseVisualStyleBackColor = false;
            // 
            // rdb_theothang
            // 
            this.rdb_theothang.AutoSize = true;
            this.rdb_theothang.BackColor = System.Drawing.Color.Transparent;
            this.rdb_theothang.Location = new System.Drawing.Point(436, 170);
            this.rdb_theothang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_theothang.Name = "rdb_theothang";
            this.rdb_theothang.Size = new System.Drawing.Size(118, 26);
            this.rdb_theothang.TabIndex = 9;
            this.rdb_theothang.TabStop = true;
            this.rdb_theothang.Text = "Theo Tháng";
            this.rdb_theothang.UseVisualStyleBackColor = false;
            // 
            // rdb_theongay
            // 
            this.rdb_theongay.AutoSize = true;
            this.rdb_theongay.BackColor = System.Drawing.Color.Transparent;
            this.rdb_theongay.Location = new System.Drawing.Point(436, 100);
            this.rdb_theongay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_theongay.Name = "rdb_theongay";
            this.rdb_theongay.Size = new System.Drawing.Size(108, 26);
            this.rdb_theongay.TabIndex = 10;
            this.rdb_theongay.TabStop = true;
            this.rdb_theongay.Text = "Theo Ngày";
            this.rdb_theongay.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 785);
            this.Controls.Add(this.grid_doanhthu);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_nam);
            this.Controls.Add(this.cmb_theothang);
            this.Controls.Add(this.date_denngay);
            this.Controls.Add(this.date_tungay);
            this.Controls.Add(this.date_theongay);
            this.Controls.Add(this.rdb_tungay);
            this.Controls.Add(this.rdb_theothang);
            this.Controls.Add(this.rdb_theongay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_thongke";
            this.Text = "THỐNG KÊ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl grid_doanhthu;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_xem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_nam;
        private System.Windows.Forms.ComboBox cmb_theothang;
        private System.Windows.Forms.DateTimePicker date_denngay;
        private System.Windows.Forms.DateTimePicker date_tungay;
        private System.Windows.Forms.DateTimePicker date_theongay;
        private System.Windows.Forms.RadioButton rdb_tungay;
        private System.Windows.Forms.RadioButton rdb_theothang;
        private System.Windows.Forms.RadioButton rdb_theongay;
        private System.Windows.Forms.Label label1;
    }
}