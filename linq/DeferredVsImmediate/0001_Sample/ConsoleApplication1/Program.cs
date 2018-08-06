///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 6th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace ConsoleApplication1
{
    using _0001_Sample;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { ID = 1, Name = "Pruthvi1"},
                new Student() {ID = 2, Name = "Avinash1" }
            };

            var deferredStudents = from student in students select student; //deferred execution.
            var immediateStudents = (from student in students select student).ToList(); //here to ToList is immediate execution.

            students.Add(new Student() { ID = 3, Name = "Pruthvi2" });
            students.Add(new Student() { ID = 4, Name = "Avinash2" });

            foreach (var deferredStudent in deferredStudents)
            {
                Console.WriteLine($"DeferredStudent \t ID: {deferredStudent.ID} \t Name: {deferredStudent.Name}");
            }
            Console.WriteLine();
            foreach (var immediateStudent in immediateStudents)
            {
                Console.WriteLine($"ImmediateStudent \t ID: {immediateStudent.ID} \t Name: {immediateStudent.Name}");
            }

            Console.ReadLine();
        }
    }
}
