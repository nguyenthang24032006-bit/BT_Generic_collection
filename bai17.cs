using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ví dụ khai báo một mảng số nguyên
            int[] numbers = { 1, 2, 3, 2, 4, 2, 5, 3 };
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            int maxCount = 0;
            int result = numbers[0];

            foreach (var item in freq)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    result = item.Key;
                }
            }

            Console.WriteLine("Số xuất hiện nhiều nhất: " + result);
        }
    }
}
