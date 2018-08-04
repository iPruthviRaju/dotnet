///----------------------------------------------------------------------
/// <File>Employee</File>
/// <Author>Pruthvi</Author>
/// <Date>August 4th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace OCP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee() { }
        public Employee(int id, string name)
        { this.ID = id; this.Name = name; }
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
