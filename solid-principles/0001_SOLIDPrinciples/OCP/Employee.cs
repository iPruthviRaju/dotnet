///----------------------------------------------------------------------
/// <File>Employee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace OCP
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee() { }
        public Employee(int id, string name)
        { this.ID = id; this.Name = name; }
        public abstract decimal CalculateBonus(decimal salary);
    }
}
