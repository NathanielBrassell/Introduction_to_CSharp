using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_nbrassell_Challege3
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        //Adds new score to list and displays updated list
        private void BtnAddScore_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txtScore.Text, out score);
            if (score > 0 && score <= 100)
            {
                Scores.Add(score);
                DisplayScores();
                txtScore.Text = "";
            }
        }

        //Removes current scores from list and displays the empty list to form
        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            Scores.Clear();
            DisplayScores();
        }

        //Displays the scores in the Scores list to form
        private void DisplayScores()
        {
            string ScoreString = "";
            foreach (var score in Scores)
            {
                ScoreString += score.ToString() + " ";
            }
            txtScores.Text = ScoreString;
        }

        //Hides the form so that data can still be retrived, button returns an OK dialog result
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //Closes the form button returns a Cancel dialog result
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Properties for transfering data betweeen forms
        public List<int> Scores { get; } = new List<int>();

        public string StudentName
        {
            get
            {
                return txtName.Text;
            }
        }
    }
}
