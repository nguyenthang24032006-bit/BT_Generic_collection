using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
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
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 1, Name = "An" });
            list.Add(new Student { Id = 2, Name = "Binh" });
            list.Add(new Student { Id = 3, Name = "Cuong" });

            Console.WriteLine("Danh sách sinh viên:");
            Console.Write("Nhập tên cần tìm: ");
            string name = Console.ReadLine();

            foreach (Student s in list)
            {
                if (s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Tìm thấy: {s.Id} - {s.Name}");
                }
            }
        }
    }
}
