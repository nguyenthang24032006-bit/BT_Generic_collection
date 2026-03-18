using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Dang Thang-2415053122339");
            List<int> numbers = new List<int>();

            Console.WriteLine("Nhập 5 số:");
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Tổng = " + sum);
        }
    }
}
