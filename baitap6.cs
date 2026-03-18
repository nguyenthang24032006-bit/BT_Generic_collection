using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Thang", "Anh", "Bao" };
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nguyen Dang Thang-2415053122339");
            Console.Write("Nhập tên cần kiểm tra: ");
            string checkName = Console.ReadLine();

            if (names.Contains(checkName))
                Console.WriteLine("Có tồn tại!");
            else
                Console.WriteLine("Không tồn tại!");
        }
    }
}

