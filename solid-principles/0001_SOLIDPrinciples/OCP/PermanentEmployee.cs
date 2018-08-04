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
        public PermanentEmployee() { }
        public PermanentEmployee(int id, string name) : base(id, name) { };
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
