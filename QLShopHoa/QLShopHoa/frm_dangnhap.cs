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
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
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
        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (txt_tendn.Text == "" || txt_mk.Text == "")
                MessageBox.Show("Bạn chưa nhập tên hoặc mật khẩu!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            txt_tendn.Focus();
            KetNoi k = new KetNoi();
            DataTable dt = k.load_bang("select * from TaiKhoan where Tendn='" + txt_tendn.Text + "' and matkhau='" + txt_mk.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông Báo!");
                txt_tendn.ResetText();
                txt_mk.ResetText();
                //Xữ lý quản lý menu
                if (cmb_quyen.Text == "1")
                {
                    GiaoDien frm = (GiaoDien)this.MdiParent;
                    frm.QL_menu("1");
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông Báo!");
                    this.Close();
                }

                else if (cmb_quyen.Text == "2")
                {
                    GiaoDien frm = (GiaoDien)this.MdiParent;
                    frm.QL_menu("2");
                    MessageBox.Show("Đăng nhập thành công với quyền nhân viên!", "Thông Báo!");
                    this.Close();
                }
                //frm_dangnhap f = new frm_dangnhap();
                //f.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông Báo!");
                txt_tendn.ResetText();
                txt_mk.ResetText();
                txt_tendn.Focus();

                GiaoDien frm = (GiaoDien)this.MdiParent;
                frm.QL_menu("0");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_dangky dk = new frm_dangky();
            dk.Show();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            load_quyen();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
