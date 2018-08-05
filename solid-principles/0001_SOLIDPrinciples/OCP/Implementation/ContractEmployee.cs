///----------------------------------------------------------------------
/// <File>ContractEmployee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 5th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace OCP
{
    using System;
    public class ContractEmployee : Employee
    {
        public ContractEmployee(int id, string name, decimal salary) : base(id, name, salary) { }
        public override decimal CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public override decimal GetMinimumSalary()
        {
            return 25000;
        }
    }
}