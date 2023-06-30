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
    public partial class frm_khachhang : Form
    {
        public frm_khachhang()
        {
            InitializeComponent();
        }
        bool kiemtranhap()
        {
            string sodt = txt_sdt.Text;
            char[] mangsodt = sodt.ToCharArray();
            long kq;
            if (txt_makh.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Khách Hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_makh.Focus();
                return false;
            }
            if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Khách Hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
                return false;
            }
            if (cmb_gioitinh.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Giới Tính Khách Hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_gioitinh.Focus();
                return false;
            }
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ Khách Hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return false;
            }
            if (txt_sdt.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại Khách Hàng !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return false;
            }
            if (!long.TryParse(sodt, out kq))
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng Số", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return false;
            }
            if (kq < 0)
            {
                MessageBox.Show("Số Điện Thoại Không Được Âm !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return false;
            }
            if (mangsodt.Length != 10)
            {
                MessageBox.Show("Số Điện Thoại Phải Đủ 10 Số !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return false;
            }
            return true;
        }
        public void load_dskh()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from KhachHang";
            binding_kh.DataSource = k.load_bang(sql);
            grid_dskh.DataSource = binding_kh;
            // Clear data của các textbox
            txt_makh.DataBindings.Clear();
            txt_tenkh.DataBindings.Clear();
            cmb_gioitinh.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            //Đổ data lên textbox
            txt_makh.DataBindings.Add("Text", binding_kh, "Makh");
            txt_tenkh.DataBindings.Add("Text", binding_kh, "Tenkh");
            cmb_gioitinh.DataBindings.Add("Text", binding_kh, "Gioitinh");
            txt_diachi.DataBindings.Add("Text", binding_kh, "Diachi");
            txt_sdt.DataBindings.Add("Text", binding_kh, "Sodt");
        }
        //Tạo mã nv tự động
        public string tao_makh()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from NhanVien";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "KH0" + so.ToString();
            return ma;
        }
        public void load_gioitinh()
        {
            KetNoi k = new KetNoi();
            cmb_gioitinh.DataSource = k.load_bang("select distinct Gioitinh from KhachHang");
            cmb_gioitinh.DisplayMember = "Gioitinh";
            cmb_gioitinh.ValueMember = "Gioitinh";
        }
        public void load_chitiet()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from KhachHang";
            grid_chitietkh.DataSource = k.load_bang(sql);
        }
        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            load_dskh();
            load_gioitinh();
            load_chitiet();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_makh.Text = tao_makh();
            txt_tenkh.ResetText();
            cmb_gioitinh.ResetText();
            txt_diachi.ResetText();
            txt_sdt.ResetText();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ten = txt_tenkh.Text;
            string diachi = txt_diachi.Text;
            if (kiemtranhap())
            {
                XuLy.suachuoi(ref ten);
                XuLy.suachuoi(ref diachi);
                KetNoi k = new KetNoi();
                string sql = "insert into KhachHang values('" + txt_makh.Text + "',N'" + ten + "','" + cmb_gioitinh.Text + "',N'" + diachi + "',N'" + txt_sdt.Text + "')";
                DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thêm Dữ Liệu ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    int sd = k.thuc_thi(sql);
                    if (sd > 0)
                    {
                        MessageBox.Show("Bạn Thêm Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_dskh();

                    }
                    else
                    {
                        MessageBox.Show("Thêm Dữ Liệu Thất Bại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }


            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (kiemtranhap())
            {

                KetNoi k = new KetNoi();
                string sql = "update KhachHang set Tenkh=N'" + txt_tenkh.Text + "',Gioitinh='" + cmb_gioitinh.Text + "',Diachi=N'" + txt_diachi.Text + "',Sodt='" + txt_sdt.Text + "'where Makh='" + txt_makh.Text + "'";
                DialogResult traloi = MessageBox.Show("Bạn Có Muốn Sửa Dữ Liệu Không !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    int sd = k.thuc_thi(sql);
                    if (sd > 0)
                    {
                        MessageBox.Show("Bạn Sửa Dữ Liệu Thành Công !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_dskh();
                    }
                    else
                    {
                        MessageBox.Show("Bạn Sửa Dữ Liệu Thất Bại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "delete from KhachHang where Makh='" + txt_makh.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Xóa Dữ Liệu Không !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn Xóa Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dskh();
                }
                else
                {
                    MessageBox.Show("Bạn Xóa Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            grid_dskh.ShowPrintPreview();
        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (navigationPane1.SelectedPageIndex == 1)
            {
                load_chitiet();
            }
            else if (navigationPane1.SelectedPageIndex == 0)
            {
                load_dskh();
            }
        }
    }
}
