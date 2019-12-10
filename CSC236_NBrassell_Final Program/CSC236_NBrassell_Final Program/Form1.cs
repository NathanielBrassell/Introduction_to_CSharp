using CSC236_NBrassell_Final_Program.Classes;
using CSC236_NBrassell_Final_Program.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_NBrassell_Final_Program
{
    delegate void Save(List<RecipeWithDrink> recipes);
    public partial class Form1 : Form
    {
        //Declare delegate
        Save save;
        //Declare BinaryFormatter
        BinaryFormatter bFormatter;
        public Form1()
        {
            bFormatter = new BinaryFormatter();
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            List<RecipeWithDrink> recipeList = new List<RecipeWithDrink>();
            foreach (var recipe in lstRecipies.Items)
            {
                recipeList.Add((RecipeWithDrink)recipe);
            }
            //Call Delegae
            save(recipeList);
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using(AddRecipe frmAddRecipe = new AddRecipe())
            {
                frmAddRecipe.ShowDialog();
                if (frmAddRecipe.DialogResult == DialogResult.OK)
                {
                    lstRecipies.Items.Add(frmAddRecipe.recipe);
                }
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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lstRecipies.SelectedItem != null)
            {
                int index = lstRecipies.SelectedIndex;
                lstRecipies.Items.RemoveAt(index);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = lstRecipies.SelectedIndex;
            RecipeWithDrink recipe = (RecipeWithDrink)lstRecipies.SelectedItem;
            using (AddRecipe frmEditRecipe = new AddRecipe(recipe))
            {
                frmEditRecipe.ShowDialog();
                if (frmEditRecipe.DialogResult == DialogResult.OK)
                {
                    lstRecipies.Items.Add(frmEditRecipe.recipe);
                    lstRecipies.Items.RemoveAt(index);
                }
            }
        }

        private void BtnSrchName_Click(object sender, EventArgs e)
        {
            List<RecipeWithDrink> recipies = new List<RecipeWithDrink>();
            foreach (var recipe in lstRecipies.Items)
            {
                recipies.Add((RecipeWithDrink)recipe);
            }
            using(SearchByName frmSearchByName = new SearchByName(recipies))
            {
                frmSearchByName.ShowDialog();
            }
        }

        private void BtnSrchIngrs_Click(object sender, EventArgs e)
        {
            List<RecipeWithDrink> recipies = new List<RecipeWithDrink>();
            foreach (var recipe in lstRecipies.Items)
            {
                recipies.Add((RecipeWithDrink)recipe);
            }
            using (SearchByIngredients frmSearchByIngredients = new SearchByIngredients(recipies))
            {
                frmSearchByIngredients.ShowDialog();
            }
        }

        private void SaveRecipies(List<RecipeWithDrink> recipeList)
        {
                //Instatiate a FileStream object to write searialized Recipies to file
                FileStream outFile = new FileStream("Recipies.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //Loop through list to access all items
                foreach (RecipeWithDrink item in recipeList)
                {
                    //Add each object to the file in serialized form
                    bFormatter.Serialize(outFile, item);
                }
                outFile.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add save function to delegate
            save = new Save(SaveRecipies);
            //Try-Catch block for file access
            try
            { 
                //Instantiate FileStream object to read serialized data from file
                FileStream inFile = new FileStream("Recipies.txt", FileMode.OpenOrCreate, FileAccess.Read);
                //Loop through all of the data in the file
                while (inFile.Position < inFile.Length)
                {
                    //Deserialize the objects stored in the file
                    RecipeWithDrink recipe = (RecipeWithDrink)bFormatter.Deserialize(inFile);
                    //Store objected in list
                    lstRecipies.Items.Add(recipe);
                }
                inFile.Close();
            }
            catch (Exception)
            {
                   MessageBox.Show("Unable to load Recipies.txt\nProgram will now close");
                   this.Close();
            }
        }
    }
}
