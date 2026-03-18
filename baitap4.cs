using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Dang Thang-2415053122339");
            int count = 0;

            List<int> numbers = new List<int>();

            Console.WriteLine("Nhap 5 so:");
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    count++;
            }

            Console.WriteLine("Số chẵn: " + count);
        }
    }
}
