using System;
using System.Collections.Generic;

namespace baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Dang Thang-2415053122339");

            // Tạo danh sách
            List<int> numbers = new List<int>();

            // Nhập 5 số
            Console.WriteLine("Nhập 5 số nguyên:");
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            // Tìm số lớn nhất
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }

            // In kết quả
            Console.WriteLine("Số lớn nhất: " + max);
        }
    }
}