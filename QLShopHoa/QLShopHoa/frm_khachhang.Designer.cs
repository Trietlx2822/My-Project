namespace QLShopHoa
{
    partial class frm_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_khachhang));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_chitietkh = new DevExpress.XtraGrid.GridControl();
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
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_dskh = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.binding_kh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitietkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dskh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_kh)).BeginInit();
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(1425, 591);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(1425, 591);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            this.navigationPane1.SelectedPageIndexChanged += new System.EventHandler(this.navigationPane1_SelectedPageIndexChanged);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Chi Tiết Khách Hàng";
            this.navigationPage1.Controls.Add(this.grid_chitietkh);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1265, 518);
            // 
            // grid_chitietkh
            // 
            this.grid_chitietkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_chitietkh.Location = new System.Drawing.Point(0, 0);
            this.grid_chitietkh.MainView = this.layoutView1;
            this.grid_chitietkh.Name = "grid_chitietkh";
            this.grid_chitietkh.Size = new System.Drawing.Size(1265, 518);
            this.grid_chitietkh.TabIndex = 1;
            this.grid_chitietkh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5});
            this.layoutView1.GridControl = this.grid_chitietkh;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Mã Khách Hàng";
            this.layoutViewColumn1.FieldName = "Makh";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(138, 22);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "Tên Khách Hàng";
            this.layoutViewColumn2.FieldName = "Tenkh";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 22);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(138, 22);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Giới Tính";
            this.layoutViewColumn3.FieldName = "Gioitinh";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 44);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(138, 23);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Địa Chỉ";
            this.layoutViewColumn4.FieldName = "Diachi";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 67);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(138, 23);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Số Điện Thoại";
            this.layoutViewColumn5.FieldName = "Sodt";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 10;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 90);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(138, 23);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(98, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn5});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 4;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Cập Nhập Khách Hàng";
            this.navigationPage2.Controls.Add(this.grid_dskh);
            this.navigationPage2.Controls.Add(this.btn_thoat);
            this.navigationPage2.Controls.Add(this.btn_in);
            this.navigationPage2.Controls.Add(this.btn_xoa);
            this.navigationPage2.Controls.Add(this.btn_sua);
            this.navigationPage2.Controls.Add(this.btn_luu);
            this.navigationPage2.Controls.Add(this.btn_them);
            this.navigationPage2.Controls.Add(this.cmb_gioitinh);
            this.navigationPage2.Controls.Add(this.txt_diachi);
            this.navigationPage2.Controls.Add(this.txt_sdt);
            this.navigationPage2.Controls.Add(this.txt_tenkh);
            this.navigationPage2.Controls.Add(this.txt_makh);
            this.navigationPage2.Controls.Add(this.label4);
            this.navigationPage2.Controls.Add(this.label5);
            this.navigationPage2.Controls.Add(this.label3);
            this.navigationPage2.Controls.Add(this.label2);
            this.navigationPage2.Controls.Add(this.label1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1265, 518);
            // 
            // grid_dskh
            // 
            this.grid_dskh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_dskh.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_dskh.Location = new System.Drawing.Point(0, 318);
            this.grid_dskh.MainView = this.gridView1;
            this.grid_dskh.Name = "grid_dskh";
            this.grid_dskh.Size = new System.Drawing.Size(1265, 200);
            this.grid_dskh.TabIndex = 27;
            this.grid_dskh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.grid_dskh;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfPageFooter = resources.GetString("gridView1.OptionsPrint.RtfPageFooter");
            this.gridView1.OptionsPrint.RtfPageHeader = resources.GetString("gridView1.OptionsPrint.RtfPageHeader");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Khách Hàng";
            this.gridColumn1.FieldName = "Makh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Khách Hàng";
            this.gridColumn2.FieldName = "Tenkh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giới Tính";
            this.gridColumn3.FieldName = "Gioitinh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "Diachi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số Điện Thoại";
            this.gridColumn5.FieldName = "Sodt";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(924, 190);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(110, 69);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Appearance.Options.UseFont = true;
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(786, 190);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(110, 69);
            this.btn_in.TabIndex = 24;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_xoa.Location = new System.Drawing.Point(637, 190);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 69);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_sua.Location = new System.Drawing.Point(507, 190);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 69);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_luu.Location = new System.Drawing.Point(373, 190);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(110, 69);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_them.Location = new System.Drawing.Point(236, 190);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 69);
            this.btn_them.TabIndex = 25;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cmb_gioitinh
            // 
            this.cmb_gioitinh.FormattingEnabled = true;
            this.cmb_gioitinh.Location = new System.Drawing.Point(571, 44);
            this.cmb_gioitinh.Name = "cmb_gioitinh";
            this.cmb_gioitinh.Size = new System.Drawing.Size(196, 24);
            this.cmb_gioitinh.TabIndex = 18;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(570, 134);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(197, 22);
            this.txt_diachi.TabIndex = 19;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(912, 44);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(207, 22);
            this.txt_sdt.TabIndex = 20;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(264, 133);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(199, 22);
            this.txt_tenkh.TabIndex = 17;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(264, 44);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(199, 22);
            this.txt_makh.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // frm_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 591);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frm_khachhang";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitietkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dskh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_kh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl grid_dskh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private System.Windows.Forms.ComboBox cmb_gioitinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grid_chitietkh;
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
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.BindingSource binding_kh;
    }
}