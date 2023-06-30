namespace QLShopHoa
{
    partial class frm_thongkechitiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongkechitiet));
            this.grid_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_tatca = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xem = new DevExpress.XtraEditors.SimpleButton();
            this.rbd_bancham = new System.Windows.Forms.RadioButton();
            this.rdb_banchay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_sp
            // 
            this.grid_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_sp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_sp.Location = new System.Drawing.Point(0, 340);
            this.grid_sp.MainView = this.gridView1;
            this.grid_sp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_sp.Name = "grid_sp";
            this.grid_sp.Size = new System.Drawing.Size(1377, 202);
            this.grid_sp.TabIndex = 11;
            this.grid_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 481;
            this.gridView1.GridControl = this.grid_sp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfReportFooter = resources.GetString("gridView1.OptionsPrint.RtfReportFooter");
            this.gridView1.OptionsPrint.RtfReportHeader = resources.GetString("gridView1.OptionsPrint.RtfReportHeader");
            // 
            // btn_thoat
            // 
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(864, 205);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(129, 56);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(692, 205);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(129, 56);
            this.btn_in.TabIndex = 8;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_tatca
            // 
            this.btn_tatca.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_tatca.Location = new System.Drawing.Point(514, 205);
            this.btn_tatca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tatca.Name = "btn_tatca";
            this.btn_tatca.Size = new System.Drawing.Size(129, 56);
            this.btn_tatca.TabIndex = 9;
            this.btn_tatca.Text = "Tất Cả \r\nSản Phẩm";
            this.btn_tatca.Click += new System.EventHandler(this.btn_tatca_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_xem.Location = new System.Drawing.Point(331, 205);
            this.btn_xem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(129, 56);
            this.btn_xem.TabIndex = 10;
            this.btn_xem.Text = "Xem";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // rbd_bancham
            // 
            this.rbd_bancham.AutoSize = true;
            this.rbd_bancham.BackColor = System.Drawing.Color.Transparent;
            this.rbd_bancham.Location = new System.Drawing.Point(713, 127);
            this.rbd_bancham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbd_bancham.Name = "rbd_bancham";
            this.rbd_bancham.Size = new System.Drawing.Size(108, 26);
            this.rbd_bancham.TabIndex = 5;
            this.rbd_bancham.TabStop = true;
            this.rbd_bancham.Text = "Bán Chậm";
            this.rbd_bancham.UseVisualStyleBackColor = false;
            // 
            // rdb_banchay
            // 
            this.rdb_banchay.AutoSize = true;
            this.rdb_banchay.BackColor = System.Drawing.Color.Transparent;
            this.rdb_banchay.Location = new System.Drawing.Point(475, 127);
            this.rdb_banchay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_banchay.Name = "rdb_banchay";
            this.rdb_banchay.Size = new System.Drawing.Size(101, 26);
            this.rdb_banchay.TabIndex = 6;
            this.rdb_banchay.TabStop = true;
            this.rdb_banchay.Text = "Bán Chạy";
            this.rdb_banchay.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHI TIẾT THỐNG KÊ";
            // 
            // frm_thongkechitiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 542);
            this.Controls.Add(this.grid_sp);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_tatca);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.rbd_bancham);
            this.Controls.Add(this.rdb_banchay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_thongkechitiet";
            this.Text = "THỐNG KÊ CHI TIẾT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_tatca;
        private DevExpress.XtraEditors.SimpleButton btn_xem;
        private System.Windows.Forms.RadioButton rbd_bancham;
        private System.Windows.Forms.RadioButton rdb_banchay;
        private System.Windows.Forms.Label label1;
    }
}