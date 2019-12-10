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
    public partial class SearchByIngredients : Form
    {
        List<RecipeWithDrink> recipeList = new List<RecipeWithDrink>();
        bool doesNotMatch = false; //Flag for if ingredient searched for is not in ingredient list of recipe.
        public SearchByIngredients(List<RecipeWithDrink> recipies)
        {
            InitializeComponent();
            foreach (RecipeWithDrink recipe in recipies)
            {
                recipeList.Add(recipe);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnAddIngr_Click(object sender, EventArgs e)
        {
            if(!Equals("", txtIngredient.Text))
            {
                lstIngredients.Items.Add(txtIngredient.Text);
                txtIngredient.Text = "";
                txtIngredient.Focus();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lstRecipies.Items.Clear();
            List<string> ingredientsList = new List<string>();
            foreach (var ingredient in lstIngredients.Items)
            {
                ingredientsList.Add((string)ingredient);
            }
            foreach (RecipeWithDrink recipe in recipeList)
            {
                doesNotMatch = false;
                foreach (string ingredient in ingredientsList)
                {
                    if (!recipe.Ingredients.Contains(ingredient))
                    {
                        doesNotMatch = true;
                    }
                }

                if (doesNotMatch == false)
                {
                    lstRecipies.Items.Add(recipe);
                }
            }
        }

        private void BtnRemoveIngr_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedItem != null)
            {
                int index = lstIngredients.SelectedIndex;
                lstIngredients.Items.RemoveAt(index);
            }
        }
    }
}
