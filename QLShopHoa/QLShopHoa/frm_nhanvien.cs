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
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        bool kiemtranhap()
        {
            string sdt = txt_sodt.Text;
            long ketqua;
            char[] mangsdt = sdt.ToCharArray();
            if (txt_manv.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Nhân Viên !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return false;
            }
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Nhân Viên !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return false;
            }
            if (cmb_gioitinh.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Giới Tính !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return false;
            }
            if (txt_sodt.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Điện Thoại Nhân Viên !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sodt.Focus();
                return false;
            }
            if (!long.TryParse(sdt, out ketqua))//Kiểm tra nếu nhập chữ báo nhập không đúng định dạng
            {
                MessageBox.Show("Hãy Nhập Đúng Định Dạng Số Điện Thoại !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sodt.Focus();
                return false;
            }
            if (ketqua < 0) // Kiểm tra nếu số âm thì báo không được âm
            {
                MessageBox.Show("Số Điện Thoại Không Được Âm !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sodt.Focus();
                return false;
            }
            if (mangsdt.Length != 10)//Kiểm tra độ dài
            {
                MessageBox.Show("Số Điện Thoại Phải Đủ 10 Chữ Số!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sodt.Focus();
                return false;
            }
            return true;
        }
        public void load_dsnv()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from NhanVien";
            binding_nv.DataSource = k.load_bang(sql);
            grid_nhanvien.DataSource = binding_nv;
            // Clear data của các textbox
            txt_manv.DataBindings.Clear();
            txt_tennv.DataBindings.Clear();
            cmb_gioitinh.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_sodt.DataBindings.Clear();
            //Đổ data lên textbox
            txt_manv.DataBindings.Add("Text", binding_nv, "Manv");
            txt_tennv.DataBindings.Add("Text", binding_nv, "Tennv");
            cmb_gioitinh.DataBindings.Add("Text", binding_nv, "Gioitinh");
            txt_diachi.DataBindings.Add("Text", binding_nv, "Diachi");
            txt_sodt.DataBindings.Add("Text", binding_nv, "Sodt");
        }
        //Tạo mã nv tự động
        public string tao_manv()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from NhanVien";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "NV0" + so.ToString();
            return ma;
        }
        public void load_gioitinh()
        {
            KetNoi k = new KetNoi();
            cmb_gioitinh.DataSource = k.load_bang("Select distinct Gioitinh from NhanVien");
            cmb_gioitinh.DisplayMember = "Gioitinh";
            cmb_gioitinh.ValueMember = "Gioitinh";

        }
        public void load_chitiet()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from NhanVien";
            grid_chitietnv.DataSource = k.load_bang(sql);
        }
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            load_chitiet();
            load_gioitinh();
            load_dsnv();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_manv.Text = tao_manv();
            txt_tennv.ResetText();
            cmb_gioitinh.ResetText();
            txt_diachi.ResetText();
            txt_sodt.ResetText();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (kiemtranhap())
            {
                KetNoi k = new KetNoi();
                string sql = "insert into NhanVien values('" + txt_manv.Text + "',N'" + txt_tennv.Text + "',N'" + cmb_gioitinh.Text + "',N'" + txt_diachi.Text + "','" + txt_sodt.Text + "')";
                DialogResult traloi = MessageBox.Show("Bạn Có Muốn Lưu Dữ Liệu Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    //Xữ Lý Dữ Liệu
                    int sd = k.thuc_thi(sql);
                    if (sd > 0)
                    {
                        MessageBox.Show("Bạn Lưu Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_dsnv();
                    }
                    else
                    {
                        MessageBox.Show("Bạn Lưu Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "update NhanVien set Tennv=N'" + txt_tennv.Text + "',Gioitinh=N'" + cmb_gioitinh.Text + "',Diachi=N'" + txt_diachi.Text + "',Sodt='" + txt_sodt.Text + "'where Manv='" + txt_manv.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Sửa Dữ Liệu Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn Sửa Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dsnv();
                }
                else
                {
                    MessageBox.Show("Bạn Sửa Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "Delete from NhanVien where Manv='" + txt_manv.Text + "'";
            DialogResult traloi = MessageBox.Show("Bạn Muốn Xóa Dữ Liệu ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn Xóa Dữ Liệu Thành Công !", "Thông Báo ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_dsnv();
                }
                else
                {
                    MessageBox.Show("Bạn Xóa Dữ Liệu Không Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_nhanvien.ShowPrintPreview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?","Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (navigationPane1.SelectedPageIndex == 1)
            {
                load_chitiet();
            }
            else if (navigationPane1.SelectedPageIndex == 0)
            {
                load_dsnv();
            }
        }
    }
}
