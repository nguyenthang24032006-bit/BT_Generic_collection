using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
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

            Console.WriteLine("Số sinh viên: " + list.Count);
        }
    }
}
