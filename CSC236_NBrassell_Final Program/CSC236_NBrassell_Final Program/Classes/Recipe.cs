using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_NBrassell_Final_Program.Classes
{
    [Serializable]
    public class Recipe
    {

        //Declaring properties
        public string Name { get; set; }
        public string Instructions { get; set; }
        public List<string> Ingredients { get; set; }

        //Constructors
        public Recipe(string name, string instructions, List<string> ingredients)
        {
            Name = name;
            Instructions = instructions;
            Ingredients = ingredients;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
