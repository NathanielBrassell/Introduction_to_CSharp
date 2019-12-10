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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logoTextDataSet1.SplashScreenText' table. You can move, or remove it, as needed.
            this.splashScreenTextTableAdapter.Fill(this.logoTextDataSet1.SplashScreenText);

        }
    }
}
