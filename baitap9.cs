using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap9
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

            List<int> uniqueList = new List<int>();

            foreach (int num in numbers)
            {
                if (!uniqueList.Contains(num))
                    uniqueList.Add(num);
            }

            Console.WriteLine("Danh sách không trùng:");
            foreach (int num in uniqueList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
