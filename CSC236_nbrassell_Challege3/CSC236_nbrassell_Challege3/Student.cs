using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_nbrassell_Challege3
{
    public class Student
    {

        public Student(string name, List<int> scores)
        {
            Name = name;
            ScoresList = scores;
        }

        //Declare properties
        public string Name { get; }
        public List<int> ScoresList { get; set; } = new List<int>();
        public char Sep { get; } = '|';

        public int ScoreCount => ScoresList.Count;

        public int ScoreTotal
        {
            get
            {
                int total = 0;
                for (int i = 0; i < ScoreCount; i++)
                {
                    total += ScoresList[i];
                }
                return total;
            }
        }

        public int ScoreAverage
        {
            get
            {
                int average = 0;
                if (ScoreTotal > 0)
                {
                    average = ScoreTotal / ScoreCount;
                }
                return average;
            }
        }

        public string GetScoresString()
        {
            string scoresString = "";
            foreach (var score in ScoresList)
            {
                scoresString += Sep.ToString() + score.ToString();
            }
            return scoresString;
        }

        public override string ToString()
        {
            string newName = Name + GetScoresString();
            return newName;
        }
    }
}