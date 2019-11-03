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
    public partial class frmUpdateScore : Form
    {
        public frmUpdateScore(int score)
        {
            InitializeComponent();
            txtScore.Text = score.ToString();
        }

        //Sets property and hides form so that data can still be retrieved
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            int.TryParse(txtScore.Text, out score);
            if (score > 0 && score <= 100)
            {
                Score = score;
            }
        }


        //Closes form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Properties for data retrivial
        public int Score { get; set; }
    }
}
