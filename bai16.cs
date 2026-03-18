using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine();

            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                    count[c] = 1;
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
