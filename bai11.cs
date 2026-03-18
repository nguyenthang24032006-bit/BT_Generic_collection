using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
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
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 1, Name = "An" });
            list.Add(new Student { Id = 2, Name = "Binh" });
            list.Add(new Student { Id = 3, Name = "Cuong" });

            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student s in list)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
            }
        }
    }
}
