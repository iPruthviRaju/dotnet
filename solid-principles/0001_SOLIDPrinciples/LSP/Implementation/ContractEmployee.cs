///----------------------------------------------------------------------
/// <File>ContractEmployee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 5th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace LSP
{
    using Interface;
    using System;
    public class ContractEmployee : IEmployee
    {
        public ContractEmployee(int id, string name, decimal salary) { this.ID = id; this.Name = name; this.Salary = salary; }

        public int ID { get; set; }

        public string Name { get; set; }
        public decimal Salary { get; set; }

        public decimal GetMinimumSalary()
        {
            return 25000;
        }
        public override string ToString()
        {
            return $"ID : {this.ID}, Name : {this.Name}, Salary : {this.Salary}";
        }
    }
}