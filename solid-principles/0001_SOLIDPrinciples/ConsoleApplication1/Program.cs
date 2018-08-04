///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace ConsoleApplication1
{
    using System;
    using OCP;
    class Program
    {
        static void Main(string[] args)
        {
            Employee pe1 = new PermanentEmployee(1, "PE1", 100000);
            Employee te1 = new TemporaryEmployee(2, "TE!", 100000);

            Console.WriteLine($"Employee {pe1.ToString()}, Bonus : {pe1.CalculateBonus()}");
            Console.WriteLine();
            Console.WriteLine($"Employee {te1.ToString()}, Bonus : {te1.CalculateBonus()}");

            Console.ReadLine();
        }
    }
}
