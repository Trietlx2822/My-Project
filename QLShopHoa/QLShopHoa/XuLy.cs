using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLShopHoa
{
    internal class XuLy
    {
        public static void suachuoi(ref string chuoi)
        {
            string resultname = "";

            //Loại bỏ khoảng trống ở 2 đầu chuỗi
            chuoi = chuoi.Trim();

            //Loại bỏ khoảng trống thừa ở giữa các từ, chuyển thành 1 khoảng trắng
            while (chuoi.IndexOf(" ") != -1)
            {
                chuoi = chuoi.Replace(" ", " ");
            }

            //sao chép các ký tự của chuổi vào một mảng
            string[] arrayname = chuoi.Split(' ');

            //Duyệt các phần tử trong mảng, chuyển ký tự đầu tiên mỗi từ thành viết hoa, còn lại viết thường
            for (int i = 0; i < arrayname.Length; i++)
            {
                arrayname[i] = arrayname[i].Substring(0, 1).ToUpper() + arrayname[i].Substring(1).ToLower();
                resultname += arrayname[i].ToString() + " ";
            }
            chuoi = resultname;

        }
    }
}
