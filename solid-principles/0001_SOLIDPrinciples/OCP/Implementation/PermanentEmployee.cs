///----------------------------------------------------------------------
/// <File>PermanentEmployee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace OCP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name, decimal salary) : base(id, name, salary) { }
        public override decimal CalculateBonus()
        {
            return this.Salary * .1M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
