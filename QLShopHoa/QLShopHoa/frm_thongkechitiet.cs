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
    public partial class frm_thongkechitiet : Form
    {
        public frm_thongkechitiet()
        {
            InitializeComponent();
        }

        private void btn_tatca_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "Select * From SanPham";
            grid_sp.DataSource = k.load_bang(sql);
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            grid_sp.RefreshDataSource();
            if (rdb_banchay.Checked == true)
            {
                KetNoi k1 = new KetNoi();
                string sql1 = "select top(1) SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,NSX,Loaisp,SUM(SanPham.Soluong) as Tong_SoLuong_Ban from SanPham,CTBanHang where SanPham.Masp = CTBanHang.Masp Group by SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,NSX,Loaisp Order by SUM(SanPham.Soluong) desc";
                grid_sp.DataSource = k1.load_bang(sql1);

            }
            else if (rbd_bancham.Checked == true)
            {
                KetNoi k = new KetNoi();
                string sql = "select top(1) SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,NSX,Loaisp,SUM(SanPham.Soluong) as Tong_SoLuong_Ban from SanPham,CTBanHang where SanPham.Masp = CTBanHang.Masp Group by SanPham.Masp,SanPham.Tensp,SanPham.Soluong,SanPham.Dongia,NSX,Loaisp Order by SUM(SanPham.Soluong) asc";
                grid_sp.DataSource = k.load_bang(sql);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_sp.ShowPrintPreview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
