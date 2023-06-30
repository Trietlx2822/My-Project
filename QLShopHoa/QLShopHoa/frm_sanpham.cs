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
    public partial class frm_sanpham : Form
    {
        public frm_sanpham()
        {
            InitializeComponent();
        }
        bool kiemtranhap()
        {
            string sl = txt_sl.Text;
            string dongia = txt_dongia.Text;
            long ketqua;
            char[] mangsl = sl.ToCharArray();
            char[] mangdongia = dongia.ToCharArray();
            if (txt_masp.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Sản Phẩm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_masp.Focus();
                return false;
            }
            if (txt_tensp.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Sản Phẩm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensp.Focus();
                return false;
            }
            if (txt_sl.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sl.Focus();
                return false;
            }
            if (txt_dongia.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Giá Tiền !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dongia.Focus();
                return false;
            }
            if (txt_nsx.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Nhà Sản Xuất !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nsx.Focus();
                return false;
            }
            if (cmb_loaisp.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Loại Sản Phẩm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_loaisp.Focus();
                return false;
            }
            if (!long.TryParse(sl, out ketqua))//Kiểm tra nếu nhập chữ báo nhập không đúng định dạng
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sl.Focus();
                return false;
            }
            if (ketqua < 0) // Kiểm tra nếu số âm thì báo không được âm
            {
                MessageBox.Show("Số Lượng Nhập Không Được Âm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sl.Focus();
                return false;
            }

            if (ketqua < 0) // Kiểm tra nếu số âm thì báo không được âm
            {
                MessageBox.Show("Số Tiền Nhập Không Được Âm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dongia.Focus();
                return false;
            }

            return true;
        }

        public void load_chitietSP()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from SanPham";
            grid_chitietsp.DataSource = k.load_bang(sql);
        }
        public void load_loaisp()
        {
            KetNoi k = new KetNoi();
            cmb_loaisp.DataSource = k.load_bang("Select distinct Loaisp from SanPham");
            cmb_loaisp.ValueMember = "Loaisp";
            cmb_loaisp.DisplayMember = "Loaisp";
        }

        public void load_gridsp()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from SanPham";
            binding_sp.DataSource = k.load_bang(sql);
            grid_sp.DataSource = binding_sp;
            //Clear SP
            txt_masp.DataBindings.Clear();
            txt_tensp.DataBindings.Clear();
            txt_sl.DataBindings.Clear();
            txt_dongia.DataBindings.Clear();
            txt_nsx.DataBindings.Clear();
            cmb_loaisp.DataBindings.Clear();
            //Đổ dữ liệu lên texbox
            txt_masp.DataBindings.Add("Text", binding_sp, "Masp");
            txt_tensp.DataBindings.Add("Text", binding_sp, "Tensp");
            txt_sl.DataBindings.Add("Text", binding_sp, "Soluong");
            txt_dongia.DataBindings.Add("Text", binding_sp, "Dongia");
            txt_nsx.DataBindings.Add("Text", binding_sp, "NSX");
            cmb_loaisp.DataBindings.Add("Text", binding_sp, "Loaisp");
        }

        public string tao_masp()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from SanPham";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "H" + so.ToString();
            return ma;
        }
        private void frm_sanpham_Load(object sender, EventArgs e)
        {
            load_loaisp();
            load_gridsp();
            load_chitietSP();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_masp.Text = tao_masp();
            txt_tensp.ResetText();
            txt_sl.ResetText();
            txt_dongia.ResetText();
            txt_nsx.ResetText();
            cmb_loaisp.ResetText();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (kiemtranhap())
            {
                KetNoi k = new KetNoi();
                string sql = "insert into SanPham values (N'" + txt_masp.Text + "',N'" + txt_tensp.Text + "','" + txt_sl.Text + "','" + txt_dongia.Text + "',N'" + txt_nsx.Text + "','" + cmb_loaisp.SelectedValue + "')";
                DialogResult traloi = MessageBox.Show("Bạn Muốn Lưu Thông Tin Sản Phẩm ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    //Xử lý dữ liệu
                    int sodong = k.thuc_thi(sql);
                    if (sodong > 0)
                    {
                        MessageBox.Show("Lưu Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_gridsp();
                    }
                    else
                    {
                        MessageBox.Show("Lưu Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "Update SanPham set Tensp=N'" + txt_tensp.Text + "',Soluong='" + txt_sl.Text + "',Dongia='" + txt_dongia.Text + "',NSX='" + txt_nsx.Text + "',Loaisp='" + cmb_loaisp.SelectedValue + "' where Masp='" + txt_masp.Text + "'";

            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Sửa Thông Tin Sản Phẩm Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                //Xữ lý dữ liệu
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Sửa Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_gridsp();
                }
                else
                {
                    MessageBox.Show("Sửa Dữ Liệu Thất Bại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "Delete from SanPham where Masp='" + txt_masp.Text + "'";

            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Xóa Dữ Liệu Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Xóa Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_gridsp();
                }
                else
                {
                    MessageBox.Show("Xóa Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_sp.ShowPrintPreview();
        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (navigationPane1.SelectedPageIndex == 1)
            {
                load_chitietSP();
            }
            else if (navigationPane1.SelectedPageIndex == 0)
            {
                load_gridsp();
            }
        }
    }
}
