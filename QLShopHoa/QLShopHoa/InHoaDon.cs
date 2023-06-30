using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLShopHoa
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=ShopHoa;Integrated Security=True");
        private void btn_in_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select HoaDon.Sohd,Ngaylap,Nguoilap,Makh,Manv,SanPham.Masp,Tensp,SanPham.Soluong,SanPham.Dongia,NSX,SanPham.Soluong*SanPham.Dongia as ThanhTien from HoaDon,SanPham,CTBanHang where HoaDon.Sohd = CTBanHang.Sohd and SanPham.Masp = CTBanHang.Masp", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

        }
    }
}
