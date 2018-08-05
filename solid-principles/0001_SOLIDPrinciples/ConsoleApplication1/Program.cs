///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            OCP.Employee ocpPE1 = new OCP.PermanentEmployee(1, "Permanent Employee 1", 100000);
            OCP.Employee ocpTE1 = new OCP.TemporaryEmployee(2, "Temporary Employee 1", 100000);
            OCP.Employee ocpCE1 = new OCP.ContractEmployee(3, "Contract Employee 1", 100000);

            Console.WriteLine($"OCP Employee {ocpPE1.ToString()}, Min Salary : {ocpPE1.GetMinimumSalary()}, Bonus : {ocpPE1.CalculateBonus()}");
            Console.WriteLine($"OCP Employee {ocpTE1.ToString()}, Min Salary : {ocpTE1.GetMinimumSalary()}, Bonus : {ocpTE1.CalculateBonus()}");
            try
            {
                Console.WriteLine($"OCP Employee {ocpCE1.ToString()}, Min Salary : {ocpCE1.GetMinimumSalary()}, Bonus : {ocpCE1.CalculateBonus()}");
            }
            catch
            {
                Console.WriteLine($"OCP Employee {ocpCE1.ToString()}, Min Salary : {ocpCE1.GetMinimumSalary()}, Bonus: error occurred while calculating bonus which is not expected for contract employee, we will fix this implementation issue in LSP.");
            }
            Console.WriteLine();

            List<LSP.Employee> employees = new List<LSP.Employee>();
            employees.Add(new LSP.PermanentEmployee(4, "Permanent Employee 2", 200000));
            employees.Add(new LSP.TemporaryEmployee(5, "Temporary Employee 2", 200000));
            //employees.Add(new LSP.ContractEmployee(6, "Contract Employee 2", 200000));
            
            foreach(var employee in employees)
            {
                Console.WriteLine($"LSP Employee {employee.ToString()}, Min Salary : {employee.GetMinimumSalary()}, Bonus : {employee.CalculateBonus()}");
            }

            Console.WriteLine();

            List<LSP.Interface.IEmployee> employeesOnly = new List<LSP.Interface.IEmployee>();
            employeesOnly.Add(new LSP.PermanentEmployee(7, "Permanent Employee 2", 200000));
            employeesOnly.Add(new LSP.TemporaryEmployee(8, "Temporary Employee 2", 200000));
            employeesOnly.Add(new LSP.ContractEmployee(9, "Contract Employee 2", 200000));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine($"LSP Employee {employee.ToString()}, Min Salary : {employee.GetMinimumSalary()}");
            }

            Console.ReadLine();
        }
    }
}
