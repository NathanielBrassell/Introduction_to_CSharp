using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_nbrassell_Challenge4.Classes
{
    public class TeamLeader : ProductionWorker
    {
        public decimal MonthlyBonus { get; set; }
        public int RequiredTrainingHours { get; set; }
        public int ActualTrainingHours { get; set; }
        public TeamLeader(string name, int number, int shift, decimal pay, decimal bonus, int reqHours, int actHours) : base(name, number, shift, pay)
        {
            MonthlyBonus = bonus;
            RequiredTrainingHours = reqHours;
            ActualTrainingHours = actHours;
            EmpType = "Team Leader";
        }
    }
}
