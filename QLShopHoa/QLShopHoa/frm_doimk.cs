using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLShopHoa
{
    public partial class frm_doimk : Form
    {
        public frm_doimk()
        {
            InitializeComponent();
        }
        
        private void frm_doimk_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=ShopHoa;Integrated Security=True");
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from TaiKhoan where Tendn=N'" + txt_tendn.Text + "'and Matkhau=N'" + txt_mkcu.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txt_tendn.Text == "" || txt_mkcu.Text == "" || txt_mkmoi.Text == "" || txt_nhaplaimk.Text == "")
            {
                error.SetError(txt_tendn, "Bạn chưa nhập tên đăng nhập!");
                error.SetError(txt_mkcu, "Bạn chưa nhập mật khẩu!");
                error.SetError(txt_mkmoi, "Bạn chưa nhập mật khẩu mới!");
                error.SetError(txt_nhaplaimk, "Bạn chưa xác nhận lại mật khẩu!");
            }
            txt_tendn.Focus();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txt_mkmoi.Text == txt_nhaplaimk.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Update TaiKhoan set Matkhau=N'" + txt_mkmoi.Text + "'where Tendn=N'" + txt_tendn.Text + "'and Matkhau=N'" + txt_mkcu.Text + "'", conn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tendn.Clear();
                    txt_mkcu.Clear();
                    txt_mkmoi.Clear();
                    txt_nhaplaimk.Clear();
                }
                else if (txt_mkmoi.Text != txt_nhaplaimk.Text)
                {
                    error.SetError(txt_nhaplaimk, "Mật khẩu không đúng!");
                }


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_dangnhap frm = new frm_dangnhap();
            frm.Show();
        }
    }
}
