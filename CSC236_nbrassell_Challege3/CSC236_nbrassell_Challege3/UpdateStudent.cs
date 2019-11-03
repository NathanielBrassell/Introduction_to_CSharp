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
    public partial class frmUpdateStudent : Form
    {
        private Student student;

        public frmUpdateStudent(Student selectedStudent)
        {
            InitializeComponent();
            student = selectedStudent;
            txtName.Text = student.Name;
            foreach (var score in student.ScoresList)
            {
                lstScores.Items.Add(score);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using(var addScoreForm = new frmAddScore())
            {
                addScoreForm.ShowDialog();
                if (addScoreForm.DialogResult == DialogResult.OK)
                {
                    lstScores.Items.Add(addScoreForm.Score);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int score = (int)lstScores.SelectedItem;
            using (var updateScoreForm = new frmUpdateScore(score))
            {
                updateScoreForm.ShowDialog();
                if (updateScoreForm.DialogResult == DialogResult.OK)
                {
                    lstScores.Items.Remove(score);
                    lstScores.Items.Add(updateScoreForm.Score);
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            lstScores.Items.RemoveAt(lstScores.SelectedIndex);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lstScores.Items.Clear();
        }

        //Hides the form so that data can still be retrived, button returns an OK dialog result
        private void BtnOK_Click(object sender, EventArgs e)
        {
            foreach (var item in lstScores.Items)
            {
                Scores.Add((int)item);
            }
            Hide();
        }

        //Closes the form, button returns a Cancel dialog result
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public List<int> Scores { get; set; } = new List<int>();
    }
}
