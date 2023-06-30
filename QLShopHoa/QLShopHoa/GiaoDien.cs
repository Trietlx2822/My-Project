using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopHoa
{
    public partial class GiaoDien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        public void load_form(Form frmload)
        {
            //Kiểm tra xem có form con đang mở mà không phải form đc gọi thì đóng lại
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            bool isLoaded = false;
            //Kiểm tra form đang gọi coi có đc mở hay chưa, nếu đã mở thì chỉ cần Acrive fomr, còn chưa thì tạo from con mới
            //Thể hiện mới và hiển thị form
            foreach (Form child in MdiChildren)
            {
                if (child.Text == frmload.Text)
                {
                    isLoaded = true;
                    frmload = child;
                    break;
                }
            }

            if (!isLoaded)
            {
                frmload.MdiParent = this;
                frmload.Location = new Point(0, 0);
                frmload.WindowState = FormWindowState.Normal;
                frmload.Show();
                frmload.Activate();
            }
            else
            {
                frmload.Activate();
            }

        }
        public void QL_menu(string quyen)
        {
            if (quyen == "1")
            {
                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = true;
                ribbon_hoadon.Visible = true;
                ribbon_thongke.Visible = true;
                ribbon_lienhe.Visible = true;
            }
            else if (quyen == "2")
            {

                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = false;
                ribbon_hoadon.Visible = true;
                ribbon_thongke.Visible = true;
                ribbon_lienhe.Visible = true;
            }
            else if (quyen == "0")
            {
                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = false;
                ribbon_hoadon.Visible = false;
                ribbon_thongke.Visible = false;
                ribbon_lienhe.Visible = true;
            }
            else if (quyen == "")
            {
                ribbon_hethong.Visible = false;
                ribbon_danhmuc.Visible = false;
                ribbon_thongke.Visible = false;
                ribbon_lienhe.Visible = true;
            }
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            QL_menu("0");
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_sanpham());
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_khachhang());
        }

        private void barButtonItem5_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_lienhe());
        }

        private void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Đăng Xuất
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
                GiaoDien_Load(sender, e);
            }
        }

        private void btn_dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_dangnhap());
        }

        private void btn_dangky_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_dangky());
        }

        private void btn_doimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_doimk());
        }

        private void btn_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_nhanvien());
        }

        private void btn_hoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_hoadon());
        }

        private void btn_tk_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_thongke());
        }

        private void btn_tkct_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_thongkechitiet());
        }

        private void btn_saoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_saoluu());
        }
    }
}