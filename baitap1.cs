using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Dang Thang-2415053122339");
        List<int> numbers = new List<int>();

        // Thêm 5 số bất kỳ
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // In các phần tử ra màn hình
        Console.WriteLine("Các phần tử trong danh sách:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}