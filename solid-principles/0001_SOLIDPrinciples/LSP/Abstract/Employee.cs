///----------------------------------------------------------------------
/// <File>Employee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace LSP
{
    using LSP.Interface;

    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee() { }
        public Employee(int id, string name, decimal salary)
        { this.ID = id; this.Name = name; this.Salary = salary; }
        public abstract decimal GetMinimumSalary();
        public abstract decimal CalculateBonus();
        public override string ToString()
        {
            return $"ID : {this.ID}, Name : {this.Name}, Salary : {this.Salary}";
        }
    }
}

