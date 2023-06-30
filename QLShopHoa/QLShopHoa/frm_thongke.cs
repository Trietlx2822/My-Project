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
    public partial class frm_thongke : Form
    {
      
        public frm_thongke()
        {
            InitializeComponent();
            for (int t = 1; t < 13; t++)
            {
                cmb_theothang.Items.Add(t);
            }
            for (int n = 1990; n < 2300; n++)
            {
                cmb_nam.Items.Add(n);
            }
        }

        private void frm_thongke_Load(object sender, EventArgs e)
        {

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            if (rdb_theongay.Checked == true)
            {
                string sql1 = "select HoaDon.Sohd,SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,SanPham.Soluong*SanPham.Dongia as ThanhTien from HoaDon,CTBanHang,SanPham where HoaDon.Sohd = CTBanHang.Sohd and CTBanHang.Masp = SanPham.Masp and Ngaylap ='" + date_theongay.Value.ToString("MM/dd/yyyy") + "'";

                KetNoi k1 = new KetNoi();
                grid_doanhthu.DataSource = k1.load_bang(sql1);
            }
            else if (rdb_theothang.Checked == true)
            {
                string sql = "select HoaDon.Sohd,SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,SanPham.Soluong*SanPham.Dongia as ThanhTien from HoaDon,CTBanHang,SanPham where HoaDon.Sohd = CTBanHang.Sohd and CTBanHang.Masp = SanPham.Masp and Month(Ngaylap) ='" + cmb_theothang.Text + "' and Year(Ngaylap)='" + cmb_nam.Text + "'";

                KetNoi k = new KetNoi();
                grid_doanhthu.DataSource = k.load_bang(sql);
            }
            else if (rdb_tungay.Checked == true)
            {
                string sql = "select HoaDon.Sohd,SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,SanPham.Soluong*SanPham.Dongia as ThanhTien from HoaDon,CTBanHang,SanPham where HoaDon.Sohd = CTBanHang.Sohd and CTBanHang.Masp = SanPham.Masp and Ngaylap between'" + date_tungay.Value.ToString("MM/dd/yyyy") + "' and '" + date_denngay.Value.ToString("MM/dd/yyyy") + "'";

                KetNoi k = new KetNoi();
                grid_doanhthu.DataSource = k.load_bang(sql);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_doanhthu.ShowPrintPreview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
