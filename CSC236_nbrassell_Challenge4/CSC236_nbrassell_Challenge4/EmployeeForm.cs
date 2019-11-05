using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_nbrassell_Challenge4
{
    public partial class frmEmployee : Form
    {
        //Use of constructor paramater to determine the name of the form, which lables are shown
        //and what the lables say
        public frmEmployee(int type)
        {
            InitializeComponent();
            if (type == 1)
            {
                this.Text = "Add Production Worker";
                lblInput1.Text = "Shift Number:";
                lblInput2.Text = "Pay Rate:";
                lblReqTrainHrs.Visible = false;
                lblActTrainHrs.Visible = false;
                txtReqTrainHrs.Visible = false;
                txtActTrainHrs.Visible = false;
                lblMonthlyBonus.Visible = false;
                txtMonthlyBonus.Visible = false;
            }
            else if (type == 2)
            {
                this.Text = "Add Shift Supervisor";
                lblInput1.Text = "Annual Salary:";
                lblInput2.Text = "Annual Bonus:";
                lblReqTrainHrs.Visible = false;
                lblActTrainHrs.Visible = false;
                txtReqTrainHrs.Visible = false;
                txtActTrainHrs.Visible = false;
                lblMonthlyBonus.Visible = false;
                txtMonthlyBonus.Visible = false;
            }
            else
            {
                this.Text = "Add Team Leader";
                lblInput1.Text = "Shift Number:";
                lblInput2.Text = "Pay Rate:";
                lblReqTrainHrs.Visible = true;
                lblActTrainHrs.Visible = true;
                txtReqTrainHrs.Visible = true;
                txtActTrainHrs.Visible = true;
                lblMonthlyBonus.Visible = true;
                txtMonthlyBonus.Visible = true;
            }
        }
    }
}
