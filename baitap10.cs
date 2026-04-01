using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nguyen Dang Thang-2415053122339");
            List<int> numbers = new List<int>();

            Console.WriteLine("Nhập 5 số:");
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }

            Console.WriteLine("Số nhỏ nhất: " + min);
        }
    }
}
