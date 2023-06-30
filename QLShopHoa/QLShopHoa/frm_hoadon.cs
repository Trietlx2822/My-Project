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
    public partial class frm_hoadon : Form
    {
        public frm_hoadon()
        {
            InitializeComponent();
        }
        public string tao_sohd()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from HoaDon";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "0" + so.ToString();
            return ma;
        }
        //Tạo combobox mã nv và kh
        public void Fill_combobox(string sql, ComboBox cmb, string ten, string ma)
        {
            KetNoi k = new KetNoi();
            cmb.DataSource = k.load_bang(sql);
            cmb.DisplayMember = ten;
            cmb.ValueMember = ma;
        }
        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            txt_sohd.Text = tao_sohd();
            txt_soluong.ResetText();
            //Đỗ dữ liệu lên combobox
            Fill_combobox("Select * from NhanVien", cmb_manv, "Manv", "Manv");
            Fill_combobox("Select * from KhachHang", cmb_makh, "Makh", "Makh");
            Fill_combobox("Select * from SanPham", cmb_masp, "Masp", "Masp");
        }

        private void cmb_manv_TextChanged(object sender, EventArgs e)
        {
            if (cmb_manv.Text == "")
                txt_tennv.Text = "";
            KetNoi k = new KetNoi();
            txt_tennv.Text = k.load_field("select Tennv from NhanVien where Manv='" + cmb_manv.Text + "'");
        }

        private void cmb_makh_TextChanged(object sender, EventArgs e)
        {
            if (cmb_makh.Text == "")
                txt_tenkh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            KetNoi k = new KetNoi();
            txt_tenkh.Text = k.load_field("Select Tenkh from KhachHang where Makh='" + cmb_makh.Text + "'");
            txt_diachi.Text = k.load_field("Select Diachi from KhachHang where Makh='" + cmb_makh.Text + "'");
            txt_sdt.Text = k.load_field("Select sodt from KhachHang where Makh='" + cmb_makh.Text + "'");
        }

        private void cmb_masp_TextChanged(object sender, EventArgs e)
        {
            if (cmb_masp.Text == "")
                txt_tensp.Text = "";
            txt_soluong.Text = "";
            txt_dongia.Text = "";
            txt_nsx.Text = "";
            KetNoi k = new KetNoi();
            txt_tensp.Text = k.load_field("select Tensp from SanPham where Masp='" + cmb_masp.Text + "'");
            txt_soluong.Text = k.load_field("select Soluong from SanPham where Masp='" + cmb_masp.Text + "'");
            txt_dongia.Text = k.load_field("select Dongia from SanPham where Masp='" + cmb_masp.Text + "'");
            txt_nsx.Text = k.load_field("select NSX from SanPham where Masp='" + cmb_masp.Text + "'");
        }
        public void load_hoadon()
        {
            KetNoi k = new KetNoi();
            cmb_makh.Text = k.load_field("select Makh from HoaDon where Sohd='" + txt_sohd.Text + "'");
            cmb_manv.Text = k.load_field("select Manv from HoaDon where Sohd='" + txt_sohd.Text + "'");
            date_ngaylap.Text = k.load_field("select Ngaylap from HoaDon where Sohd='" + txt_sohd.Text + "'");
        }

        public void load_cthoadon()
        {
            string sql = "select SanPham.Masp,Tensp,SanPham.Soluong,SanPham.Dongia,NSX,SanPham.Soluong*SanPham.Dongia as Thanhtien";
            sql += "from SanPham,CTBanHang where CTBanHang.Masp = SanPham.Masp and Sohd='" + txt_sohd.Text + "'";
            KetNoi k = new KetNoi();
            DataTable dt_hoadon = k.load_bang(sql);
            foreach (DataRow r in dt_hoadon.Rows)
            {
                ListViewItem l = new ListViewItem(r[0].ToString());
                l.SubItems.Add(r[1].ToString());
                l.SubItems.Add(r[2].ToString());
                l.SubItems.Add(r[3].ToString());
                list_sanpham.Items.Add(l);

            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                //Xữ Lý Hóa Đơn
                bool trangthai;
                string sql = "insert into HoaDon values('" + txt_sohd.Text + "','" + date_ngaylap.Value.ToString("MM/dd/yyyy") + "',N'" + txt_tennv.Text + "','" + cmb_makh.Text + "','" + cmb_manv.Text + "')";

                KetNoi k = new KetNoi();
                int dong = k.thuc_thi(sql);
                if (dong > 0)
                {
                    trangthai = true;
                    //Xũ Lý Thêm CT Hóa Đơn
                    foreach (ListViewItem l in list_sanpham.Items)
                    {
                        KetNoi k1 = new KetNoi();
                        string sql1 = "insert into CTBanHang values('" + l.SubItems[0].Text + "','" + txt_sohd.Text + "','" + l.SubItems[2].Text + "','" + txt_dongia.Text + "')";
                        if (k1.thuc_thi(sql1) > 0)
                            trangthai = true;
                        else
                            trangthai = false;
                    }
                }
                else
                    trangthai = false;
                if (trangthai == true)
                    MessageBox.Show("Lưu Hóa Đơn Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Lưu Hóa Đơn Thất Bại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi Cơ Sở Dữ Liệu !", exp.ToString());
            }
        }
        bool kiemtranhap()
        {
            string sl = txt_soluong.Text;
            char[] mangsl = sl.ToCharArray();
            long kq;
            if (txt_soluong.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return false;
            }
            if (!long.TryParse(sl, out kq))
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng Số !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return false;
            }
            if (kq < 0)
            {
                MessageBox.Show("Số Lượng Nhập Không Được Âm !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return false;
            }
            return true;

        }
        private void btn_themhang_Click(object sender, EventArgs e)
        {
            if (kiemtranhap())
            {
                bool kt = true;
                foreach (ListViewItem i in list_sanpham.Items)
                {
                    if (i.SubItems[0].Text == cmb_masp.Text)
                    {
                        kt = false;
                        break;
                    }
                }
                if (kt == false)
                {
                    if (MessageBox.Show("Sản Phẩm Này Đã Tồn Tại Trong Giỏ Hàng ! Bạn Có Muốn Thêm Số Lượng !", "Thông Báo !", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        foreach (ListViewItem i in list_sanpham.Items)
                        {
                            if (i.SubItems[0].Text == cmb_masp.Text)
                            {
                                int sl = Int32.Parse(i.SubItems[2].Text) + Int32.Parse(txt_soluong.Text);
                                i.SubItems[2].Text = sl.ToString();

                                //Cập nhập thành tiền
                                double tongtien = Double.Parse(i.SubItems[3].Text) * Double.Parse(i.SubItems[5].Text);
                                i.SubItems[5].Text = tongtien.ToString();
                            }
                        }
                    }
                }
                else
                {
                    ListViewItem item = new ListViewItem(cmb_masp.Text);
                    item.SubItems.Add(txt_tensp.Text);
                    item.SubItems.Add(txt_soluong.Text);
                    item.SubItems.Add(txt_dongia.Text);
                    item.SubItems.Add(txt_nsx.Text);
                    double thanhtien = Double.Parse(txt_soluong.Text) * Double.Parse(txt_dongia.Text);
                    item.SubItems.Add(thanhtien.ToString());
                    list_sanpham.Items.Add(item);
                }
                double tt = 0;
                foreach (ListViewItem item in list_sanpham.Items)
                {
                    tt += Single.Parse(item.SubItems[5].Text);
                }
                txt_tongtien.Text = tt.ToString();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            list_sanpham.ResetText();
            txt_sohd.ResetText();
            date_ngaylap.ResetText();
            cmb_manv.ResetText();
            cmb_makh.ResetText();
            txt_tongtien.ResetText();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            InHoaDon frm_in = new InHoaDon();
            frm_in.ShowDialog();
        }
    }
}
