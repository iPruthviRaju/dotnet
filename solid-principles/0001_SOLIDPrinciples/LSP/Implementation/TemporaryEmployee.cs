﻿///----------------------------------------------------------------------
/// <File>TemporaryEmployee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 5th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace LSP
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name, decimal salary) : base(id, name, salary) { }
        public override decimal CalculateBonus()
        {
            return this.Salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 20000;
        }
    }
}
