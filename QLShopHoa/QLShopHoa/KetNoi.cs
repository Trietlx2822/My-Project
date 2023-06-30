using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLShopHoa
{
    public partial class KetNoi : Component
    {
        SqlConnection conn;
        SqlCommand cmd;
        string chuoikn = @"Data Source=LENOVO;Initial Catalog=ShopHoa;Integrated Security=True";
        public KetNoi()
        {
            conn = new SqlConnection(chuoikn);
            conn.Open();
            InitializeComponent();
        }

        public KetNoi(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //ham dung de do du lieu tu bang len database
        public DataTable load_bang(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable bang = new DataTable();
                da.Fill(bang);
                return bang;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }
        public int thuc_thi(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, conn);
                int sodong = cmd.ExecuteNonQuery();
                return sodong;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        //Hàm load filed của bản
        public string load_field(string sql)
        {
            string ma = "";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    
}
}
