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
    public partial class SearchByName : Form
    {
        List<RecipeWithDrink> recipeList = new List<RecipeWithDrink>();
        public SearchByName(List<RecipeWithDrink> recipies)
        {
            InitializeComponent();
            foreach (RecipeWithDrink recipe in recipies)
            {
                recipeList.Add(recipe);
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (lstRecipies.SelectedItem != null)
            {
                RecipeWithDrink recipe = (RecipeWithDrink)lstRecipies.SelectedItem;
                using (ViewRecipe frmViewRecipe = new ViewRecipe(recipe))
                {
                    frmViewRecipe.ShowDialog();
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!Equals("", txtName.Text))
            {
                lstRecipies.Items.Clear();
                string searchName = txtName.Text.ToLower();
                foreach (RecipeWithDrink recipe in recipeList)
                {
                    string recipeName = recipe.Name.ToLower();
                    if (recipeName.Contains(searchName))
                    {
                        lstRecipies.Items.Add(recipe);
                    }
                }
            }
        }
    }
}
