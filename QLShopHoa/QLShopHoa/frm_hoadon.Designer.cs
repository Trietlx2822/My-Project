namespace QLShopHoa
{
    partial class frm_hoadon
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
            this.list_sanpham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_themhang = new DevExpress.XtraEditors.SimpleButton();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.cmb_masp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_taomoi = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_makh = new System.Windows.Forms.ComboBox();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.date_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_sohd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_sanpham
            // 
            this.list_sanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.list_sanpham.GridLines = true;
            this.list_sanpham.HideSelection = false;
            this.list_sanpham.Location = new System.Drawing.Point(64, 616);
            this.list_sanpham.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.list_sanpham.Name = "list_sanpham";
            this.list_sanpham.Size = new System.Drawing.Size(1648, 214);
            this.list_sanpham.TabIndex = 77;
            this.list_sanpham.UseCompatibleStateImageBehavior = false;
            this.list_sanpham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sản Phẩm";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sản Phẩm";
            this.columnHeader2.Width = 268;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhà Sản Xuất";
            this.columnHeader5.Width = 268;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tổng Tiền";
            this.columnHeader6.Width = 276;
            // 
            // btn_themhang
            // 
            this.btn_themhang.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themhang.Appearance.Options.UseFont = true;
            this.btn_themhang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_themhang.Location = new System.Drawing.Point(1285, 472);
            this.btn_themhang.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_themhang.Name = "btn_themhang";
            this.btn_themhang.Size = new System.Drawing.Size(159, 53);
            this.btn_themhang.TabIndex = 76;
            this.btn_themhang.Text = "Thêm Mặt Hàng";
            this.btn_themhang.Click += new System.EventHandler(this.btn_themhang_Click);
            // 
            // txt_nsx
            // 
            this.txt_nsx.Location = new System.Drawing.Point(1029, 437);
            this.txt_nsx.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(229, 30);
            this.txt_nsx.TabIndex = 71;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(636, 440);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(229, 30);
            this.txt_soluong.TabIndex = 72;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(636, 533);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(229, 30);
            this.txt_dongia.TabIndex = 73;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(1029, 537);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(229, 30);
            this.txt_tongtien.TabIndex = 74;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(279, 533);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(229, 30);
            this.txt_tensp.TabIndex = 75;
            // 
            // cmb_masp
            // 
            this.cmb_masp.FormattingEnabled = true;
            this.cmb_masp.Location = new System.Drawing.Point(276, 437);
            this.cmb_masp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmb_masp.Name = "cmb_masp";
            this.cmb_masp.Size = new System.Drawing.Size(234, 30);
            this.cmb_masp.TabIndex = 70;
            this.cmb_masp.TextChanged += new System.EventHandler(this.cmb_masp_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(547, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 22);
            this.label13.TabIndex = 64;
            this.label13.Text = "Đơn Giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(900, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 22);
            this.label14.TabIndex = 65;
            this.label14.Text = "Nhà Sản Xuất";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(900, 541);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 22);
            this.label15.TabIndex = 66;
            this.label15.Text = "Tổng Tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(547, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 67;
            this.label12.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(147, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 22);
            this.label11.TabIndex = 68;
            this.label11.Text = "Tên Sản Phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(147, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 22);
            this.label10.TabIndex = 69;
            this.label10.Text = "Mã Sản Phẩm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Location = new System.Drawing.Point(1129, 320);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(140, 62);
            this.btn_thoat.TabIndex = 63;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Appearance.Options.UseFont = true;
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Location = new System.Drawing.Point(939, 320);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(140, 62);
            this.btn_in.TabIndex = 62;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Appearance.Options.UseFont = true;
            this.btn_huy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_huy.Location = new System.Drawing.Point(731, 320);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(140, 62);
            this.btn_huy.TabIndex = 61;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_luu.Location = new System.Drawing.Point(528, 320);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(140, 62);
            this.btn_luu.TabIndex = 60;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_taomoi
            // 
            this.btn_taomoi.Appearance.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taomoi.Appearance.Options.UseFont = true;
            this.btn_taomoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_taomoi.Location = new System.Drawing.Point(328, 320);
            this.btn_taomoi.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_taomoi.Name = "btn_taomoi";
            this.btn_taomoi.Size = new System.Drawing.Size(140, 62);
            this.btn_taomoi.TabIndex = 59;
            this.btn_taomoi.Text = "Tạo Mới";
            this.btn_taomoi.Click += new System.EventHandler(this.btn_taomoi_Click);
            // 
            // cmb_makh
            // 
            this.cmb_makh.FormattingEnabled = true;
            this.cmb_makh.Location = new System.Drawing.Point(983, 135);
            this.cmb_makh.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmb_makh.Name = "cmb_makh";
            this.cmb_makh.Size = new System.Drawing.Size(237, 30);
            this.cmb_makh.TabIndex = 58;
            this.cmb_makh.TextChanged += new System.EventHandler(this.cmb_makh_TextChanged);
            // 
            // cmb_manv
            // 
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(538, 135);
            this.cmb_manv.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(237, 30);
            this.cmb_manv.TabIndex = 57;
            this.cmb_manv.TextChanged += new System.EventHandler(this.cmb_manv_TextChanged);
            // 
            // date_ngaylap
            // 
            this.date_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaylap.Location = new System.Drawing.Point(146, 225);
            this.date_ngaylap.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.date_ngaylap.Name = "date_ngaylap";
            this.date_ngaylap.Size = new System.Drawing.Size(235, 30);
            this.date_ngaylap.TabIndex = 56;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(1365, 131);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(235, 30);
            this.txt_diachi.TabIndex = 54;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(1365, 225);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(235, 30);
            this.txt_sdt.TabIndex = 55;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(979, 225);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(235, 30);
            this.txt_tenkh.TabIndex = 53;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(534, 225);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(235, 30);
            this.txt_tennv.TabIndex = 52;
            // 
            // txt_sohd
            // 
            this.txt_sohd.Location = new System.Drawing.Point(153, 135);
            this.txt_sohd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txt_sohd.Name = "txt_sohd";
            this.txt_sohd.Size = new System.Drawing.Size(235, 30);
            this.txt_sohd.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1236, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 49;
            this.label9.Text = "Số Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1243, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(829, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(835, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(404, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(411, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Số Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Alexander", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 45);
            this.label1.TabIndex = 42;
            this.label1.Text = "Phiếu Hóa Đơn";
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 841);
            this.Controls.Add(this.list_sanpham);
            this.Controls.Add(this.btn_themhang);
            this.Controls.Add(this.txt_nsx);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.cmb_masp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_taomoi);
            this.Controls.Add(this.cmb_makh);
            this.Controls.Add(this.cmb_manv);
            this.Controls.Add(this.date_ngaylap);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_sohd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UTM Alexander", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_hoadon";
            this.Text = "HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_sanpham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevExpress.XtraEditors.SimpleButton btn_themhang;
        private System.Windows.Forms.TextBox txt_nsx;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.ComboBox cmb_masp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_taomoi;
        private System.Windows.Forms.ComboBox cmb_makh;
        private System.Windows.Forms.ComboBox cmb_manv;
        private System.Windows.Forms.DateTimePicker date_ngaylap;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_sohd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}