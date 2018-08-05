///----------------------------------------------------------------------
/// <File>IEmployeeBonus</File>
/// <Author>Pruthvi</Author>
/// <Date>August 5th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace LSP.Interface
{
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
        decimal GetMinimumSalary();
        string ToString();
    }
}
