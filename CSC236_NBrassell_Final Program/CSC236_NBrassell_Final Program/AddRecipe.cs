using CSC236_NBrassell_Final_Program.Classes;
using CSC236_NBrassell_Final_Program.Enumerations;
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
    public partial class AddRecipe : Form
    {
        public RecipeWithDrink recipe { get; set; }
        //Default constructor to create a new recipe
        public AddRecipe()
        {
            InitializeComponent();
            btnEditRecipe.Visible = false;
            btnAddRecipe.Visible = true;
            cmbxDringPair.SelectedItem = cmbxDringPair.Items[1];
        }
        //Overloaded constructor to edit existing recipe
        //Puts object data into appropriate fields
        public AddRecipe(RecipeWithDrink recipe)
        {
            InitializeComponent();
            this.Text = "Edit Recipe";
            btnAddRecipe.Visible = false;
            btnEditRecipe.Visible = true;
            txtName.Text = recipe.Name;
            txtInstructions.Text = recipe.Instructions;
            cmbxDringPair.SelectedItem = recipe.DrinkPair.ToString();
            foreach (string ingredient in recipe.Ingredients)
            {
                lstIngredients.Items.Add(ingredient);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Adds ingredient to list
        private void BtnAddIngr_Click(object sender, EventArgs e)
        {
            //Check to make sure that the field is not empty
            if (!Equals("", txtIngredient.Text))
            {
                lstIngredients.Items.Add(txtIngredient.Text);
                txtIngredient.Text = "";
                txtIngredient.Focus();
            }
        }

        //Removes selected ingredient from list
        private void BtnRemoveIngr_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedItem != null)
            {
                int index = lstIngredients.SelectedIndex;
                lstIngredients.Items.RemoveAt(index);
            }
        }

        private void BtnAddRecipe_Click(object sender, EventArgs e)
        {
            Drink drinkPair;
            string name = txtName.Text;
            string instructions = txtInstructions.Text;
            List<string> ingredients = new List<string>();
            Enum.TryParse(cmbxDringPair.SelectedItem.ToString(), out drinkPair);
            foreach (var item in lstIngredients.Items)
            {
                ingredients.Add(item.ToString());
            }
            //Instantiate object with user input
            recipe = new RecipeWithDrink(name, instructions, drinkPair, ingredients);
        }

        private void BtnEditRecipe_Click(object sender, EventArgs e)
        {
            Drink drinkPair;
            string name = txtName.Text;
            string instructions = txtInstructions.Text;
            List<string> ingredients = new List<string>();
            Enum.TryParse(cmbxDringPair.SelectedItem.ToString(), out drinkPair);
            foreach (var item in lstIngredients.Items)
            {
                ingredients.Add(item.ToString());
            }
            //Instatiate object with user input
            recipe = new RecipeWithDrink(name, instructions, drinkPair, ingredients);
        }

    }
}
