using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    class Student
    {
        public string Name;
        public double Score;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Name = "An", Score = 7.5 });
            list.Add(new Student { Name = "Binh", Score = 9.0 });
            list.Add(new Student { Name = "Cuong", Score = 8.0 });

            // Tìm điểm cao nhất
            double max = list[0].Score;
            Student top = list[0];

            foreach (Student s in list)
            {
                if (s.Score > max)
                {
                    max = s.Score;
                    top = s;
                }
            }

            Console.WriteLine($"Sinh viên cao điểm nhất: {top.Name} - {top.Score}");
        }
    }
}
