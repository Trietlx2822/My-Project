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
    public partial class frm_saoluu : Form
    {
        public frm_saoluu()
        {
            InitializeComponent();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txt_duongdan.Text = folderBrowserDialog1.SelectedPath;
            }    
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            try
            {
                if(txt_duongdan.Text!=""&&txt_teptin.Text!="")
                {
                    string file_path = txt_duongdan.Text + "\\" + txt_teptin.Text + ".bak";
                    string sql = "backup database ShopHoa to disk ='" + file_path + "'";
                    k.thuc_thi(sql);
                    MessageBox.Show("Sao Lưu Dữ Liệu Thành Công !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Sao Lưu Dữ Liệu Thất Bại !", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch(Exception epx) {
                MessageBox.Show(epx.ToString(), "Lỗi SQL");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi==DialogResult.OK)
                this.Close();
        }
    }
}
