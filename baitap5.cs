using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nguyen Dang Thang-2415053122339");
            List<string> names = new List<string>() { "An", "Bình", "Cường", "Dung" };

            Console.Write("Nhập tên cần xóa: ");
            string name = Console.ReadLine();

            names.Remove(name);

            Console.WriteLine("Danh sách còn lại:");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
