using _0001_Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { ID = 1, Name = "Pruthvi1"},
                new Student() {ID = 2, Name = "Avinash1" }
            };

            var deferredStudents = from student in students select student;
            var immediateStudens = students.ToList();

            students.Add(new Student() { ID = 3, Name = "Pruthvi2"});
            students.Add(new Student() { ID = 4, Name = "Avinash2" });
        }
    }
}
