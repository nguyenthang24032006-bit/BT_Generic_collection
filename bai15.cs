using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    class Student
    {
        public int Id;
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NguyenDangthang-2415053122339");
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("hello", "xin chào");
            dict.Add("book", "quyển sách");
            dict.Add("cat", "con mèo");

            Console.Write("Nhập từ tiếng Anh: ");
            string eng = Console.ReadLine();

            if (dict.ContainsKey(eng))
                Console.WriteLine("Nghĩa: " + dict[eng]);
            else
                Console.WriteLine("Không tìm thấy!");
        }
    }
}
