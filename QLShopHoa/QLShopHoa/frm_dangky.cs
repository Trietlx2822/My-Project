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
    public partial class frm_dangky : Form
    {
        public frm_dangky()
        {
            InitializeComponent();
        }
        public void load_quyen()
        {
            KetNoi k = new KetNoi();
            cmb_quyen.DataSource = k.load_bang("select distinct Quyen from TaiKhoan");
            cmb_quyen.DisplayMember = "Quyen";
            cmb_quyen.ValueMember = "Quyen";
        }
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (txt_tendn.Text == "" || txt_mk.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Trống !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tendn.Focus();
            }
            else
            {
                //Kiểm tra tài khoản có tồn tại hay chưa
                string caulenh = "Select * from TaiKhoan where Tendn='" + txt_tendn.Text + "'";
                KetNoi k = new KetNoi();
                DataTable dt = k.load_bang(caulenh);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_tendn.Text = "";
                    txt_tendn.Focus();
                    txt_mk.Text = "";
                }
                else
                {
                    string sql = "insert into TaiKhoan values('" + txt_tendn.Text + "','" + txt_mk.Text + "','" + cmb_quyen.SelectedValue + "')";
                    try
                    {
                        KetNoi kn = new KetNoi();
                        int dong = kn.thuc_thi(sql);
                        if (dong > 0)
                        {
                            MessageBox.Show("Bạn Đăng Ký Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng Ký Thất Bại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_tendn.Text = "";
                            txt_mk.Text = "";
                            txt_tendn.Focus();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void frm_dangky_Load(object sender, EventArgs e)
        {
            load_quyen();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_dangnhap dn = new frm_dangnhap();
            dn.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
