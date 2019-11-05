using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_nbrassell_Challenge4.Classes
{
    public abstract class Employee
    {
        public string EmpName { get; set; }
        public int EmpNumber { get; set; }
        public string EmpType { get; set; }

        public Employee(string name, int number)
        {
            EmpName = name;
            EmpNumber = number;
        }

        public override string ToString()
        {
            return $"{EmpName} | {EmpNumber} | {EmpType}";
        }
    }
}
