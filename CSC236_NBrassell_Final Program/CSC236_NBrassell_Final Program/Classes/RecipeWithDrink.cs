using CSC236_NBrassell_Final_Program.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_NBrassell_Final_Program.Classes
{
    //Implenting Serializable for ease of data storage and recovery from text file
    [Serializable]
    public class RecipeWithDrink : Recipe
    {
        public Drink DrinkPair { get; set; }

        public RecipeWithDrink(string name, string instructions, Drink drink, List<string> ingredients) : 
            base(name, instructions, ingredients)
        {
            DrinkPair = drink;
        }
    }
}
