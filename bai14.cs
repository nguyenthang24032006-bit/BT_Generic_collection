using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
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
            Console.Write("Nhập ID cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            list.RemoveAll(s => s.Id == id);

            Console.WriteLine("Danh sách sau khi xóa:");
            foreach (Student s in list)
            {
                Console.WriteLine($"{s.Id} - {s.Name}");
            }

        }
    }
}
