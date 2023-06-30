namespace QLShopHoa
{
    partial class frm_sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sanpham));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_chitietsp = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_loaisp = new System.Windows.Forms.ComboBox();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.binding_sp = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitietsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1293, 656);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(1293, 656);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.SelectedPageIndexChanged += new System.EventHandler(this.navigationPane1_SelectedPageIndexChanged);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Chi Tiết Sản Phẩm";
            this.navigationPage1.Controls.Add(this.grid_chitietsp);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1142, 583);
            // 
            // grid_chitietsp
            // 
            this.grid_chitietsp.Location = new System.Drawing.Point(271, 105);
            this.grid_chitietsp.MainView = this.layoutView1;
            this.grid_chitietsp.Name = "grid_chitietsp";
            this.grid_chitietsp.Size = new System.Drawing.Size(400, 200);
            this.grid_chitietsp.TabIndex = 0;
            this.grid_chitietsp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6});
            this.layoutView1.GridControl = this.grid_chitietsp;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã Sản Phẩm";
            this.layoutViewColumn1.FieldName = "Masp";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.MinWidth = 25;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 94;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên Sản Phẩm";
            this.layoutViewColumn2.FieldName = "Tensp";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.MinWidth = 25;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 94;
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 25);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Số Lượng";
            this.layoutViewColumn3.FieldName = "Soluong";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.MinWidth = 25;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Width = 94;
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 50);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Đơn Giá";
            this.layoutViewColumn4.FieldName = "Dongia";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.layoutViewColumn4.MinWidth = 25;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Width = 94;
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 75);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Nhà Sản Xuất";
            this.layoutViewColumn5.FieldName = "NSX";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.MinWidth = 25;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            this.layoutViewColumn5.Width = 94;
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "Loại Sản Phẩm";
            this.layoutViewColumn6.FieldName = "Loaisp";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_layoutViewColumn6;
            this.layoutViewColumn6.MinWidth = 25;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            this.layoutViewColumn6.Width = 94;
            // 
            // layoutViewField_layoutViewColumn6
            // 
            this.layoutViewField_layoutViewColumn6.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn6.Location = new System.Drawing.Point(0, 125);
            this.layoutViewField_layoutViewColumn6.Name = "layoutViewField_layoutViewColumn6";
            this.layoutViewField_layoutViewColumn6.Size = new System.Drawing.Size(135, 25);
            this.layoutViewField_layoutViewColumn6.TextSize = new System.Drawing.Size(90, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn5,
            this.layoutViewField_layoutViewColumn6});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Cập Nhập Sản Phẩm";
            this.navigationPage2.Controls.Add(this.grid_sp);
            this.navigationPage2.Controls.Add(this.btn_thoat);
            this.navigationPage2.Controls.Add(this.btn_in);
            this.navigationPage2.Controls.Add(this.btn_xoa);
            this.navigationPage2.Controls.Add(this.btn_sua);
            this.navigationPage2.Controls.Add(this.btn_luu);
            this.navigationPage2.Controls.Add(this.btn_them);
            this.navigationPage2.Controls.Add(this.cmb_loaisp);
            this.navigationPage2.Controls.Add(this.txt_nsx);
            this.navigationPage2.Controls.Add(this.txt_sl);
            this.navigationPage2.Controls.Add(this.txt_dongia);
            this.navigationPage2.Controls.Add(this.txt_tensp);
            this.navigationPage2.Controls.Add(this.txt_masp);
            this.navigationPage2.Controls.Add(this.label6);
            this.navigationPage2.Controls.Add(this.label5);
            this.navigationPage2.Controls.Add(this.label3);
            this.navigationPage2.Controls.Add(this.label4);
            this.navigationPage2.Controls.Add(this.label2);
            this.navigationPage2.Controls.Add(this.label1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1142, 583);
            // 
            // grid_sp
            // 
            this.grid_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_sp.Location = new System.Drawing.Point(0, 393);
            this.grid_sp.MainView = this.gridView2;
            this.grid_sp.Name = "grid_sp";
            this.grid_sp.Size = new System.Drawing.Size(1142, 190);
            this.grid_sp.TabIndex = 29;
            this.grid_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.GridControl = this.grid_sp;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.RtfReportFooter = resources.GetString("gridView2.OptionsPrint.RtfReportFooter");
            this.gridView2.OptionsPrint.RtfReportHeader = resources.GetString("gridView2.OptionsPrint.RtfReportHeader");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Sản Phẩm";
            this.gridColumn1.FieldName = "Masp";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Sản Phẩm";
            this.gridColumn2.FieldName = "Tensp";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số Lượng";
            this.gridColumn3.FieldName = "Soluong";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn Giá";
            this.gridColumn4.FieldName = "Dongia";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nhà Sản Xuất";
            this.gridColumn5.FieldName = "NSX";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Loại Sản Phẩm";
            this.gridColumn6.FieldName = "Loaisp";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(890, 275);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(102, 66);
            this.btn_thoat.TabIndex = 28;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Appearance.Options.UseFont = true;
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(747, 275);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(102, 66);
            this.btn_in.TabIndex = 27;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_xoa.Location = new System.Drawing.Point(613, 275);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(102, 66);
            this.btn_xoa.TabIndex = 26;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_sua.Location = new System.Drawing.Point(463, 275);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(102, 66);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Cập Nhập";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_luu.Location = new System.Drawing.Point(320, 275);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(102, 66);
            this.btn_luu.TabIndex = 24;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_them.Location = new System.Drawing.Point(174, 275);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(102, 66);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cmb_loaisp
            // 
            this.cmb_loaisp.FormattingEnabled = true;
            this.cmb_loaisp.Location = new System.Drawing.Point(767, 207);
            this.cmb_loaisp.Name = "cmb_loaisp";
            this.cmb_loaisp.Size = new System.Drawing.Size(188, 24);
            this.cmb_loaisp.TabIndex = 23;
            // 
            // txt_nsx
            // 
            this.txt_nsx.Location = new System.Drawing.Point(767, 111);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(188, 22);
            this.txt_nsx.TabIndex = 22;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(377, 208);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(188, 22);
            this.txt_sl.TabIndex = 19;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(767, 36);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(188, 22);
            this.txt_dongia.TabIndex = 20;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(377, 117);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(188, 22);
            this.txt_tensp.TabIndex = 18;
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(377, 42);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(188, 22);
            this.txt_masp.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhà Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // frm_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 656);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frm_sanpham";
            this.Text = "SẢN PHẨM";
            this.Load += new System.EventHandler(this.frm_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitietsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_sp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl grid_chitietsp;
        private DevExpress.XtraGrid.GridControl grid_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.ComboBox cmb_loaisp;
        private System.Windows.Forms.TextBox txt_nsx;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.BindingSource binding_sp;
    }
}