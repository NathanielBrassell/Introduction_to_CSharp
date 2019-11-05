using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_nbrassell_Challenge4.Classes
{
    public class ProductionWorker : Employee
    {
        public int ShiftNumber { get; set; }
        public decimal PayRate { get; set; }
        public ProductionWorker(string name, int number, int shift, decimal pay) : base(name, number)
        {
            ShiftNumber = shift;
            PayRate = pay;
            EmpType = "Production Worker";
        }
    }
}
