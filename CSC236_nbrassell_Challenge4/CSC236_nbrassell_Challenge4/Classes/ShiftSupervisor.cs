using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_nbrassell_Challenge4.Classes
{
    public class ShiftSupervisor : Employee
    {
        public decimal AnnualSalary { get; set; }
        public decimal AnnualProductionBonus { get; set; }
        public ShiftSupervisor(string name, int number, decimal salary, decimal bonus) : base(name, number)
        {
            AnnualSalary = salary;
            AnnualProductionBonus = bonus;
            EmpType = "Shift Supervisor";
        }
    }
}
