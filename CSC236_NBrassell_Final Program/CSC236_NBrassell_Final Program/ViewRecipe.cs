using CSC236_NBrassell_Final_Program.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_NBrassell_Final_Program
{
    public partial class ViewRecipe : Form
    {
        public ViewRecipe(RecipeWithDrink recipe)
        {
            InitializeComponent();
            txtName.Text = recipe.Name;
            txtInstructions.Text = recipe.Instructions;
            txtDrink.Text = recipe.DrinkPair.ToString();
            foreach (string ingredient in recipe.Ingredients)
            {
                lstIngredients.Items.Add(ingredient);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
