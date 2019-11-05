using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSC236_nbrassell_Challenge4.Classes;

namespace CSC236_nbrassell_Challenge4
{
    public partial class frmMain : Form
    {
        public int counter = 1; //Counter for generating new, unique Employee IDs
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lstEmployeeList.Items.Remove(lstEmployeeList.SelectedItem);
        }

        private void BtnAddProdWorker_Click(object sender, EventArgs e)
        {
            using (frmEmployee addEmployeeForm = new frmEmployee(1))
            {
                addEmployeeForm.ShowDialog();
                if (addEmployeeForm.DialogResult == DialogResult.OK)
                {
                    string name = addEmployeeForm.txtName.Text;
                    int shift;
                    int.TryParse(addEmployeeForm.txtInput1.Text, out shift);
                    decimal pay;
                    decimal.TryParse(addEmployeeForm.txtInput2.Text, out pay);
                    ProductionWorker employee = new ProductionWorker(name, counter, shift, pay);
                    lstEmployeeList.Items.Add(employee);
                    counter++;
                }
            }
        }

        private void BtnAddShiftSuper_Click(object sender, EventArgs e)
        {
            using (frmEmployee addEmployeeForm = new frmEmployee(2))
            {
                addEmployeeForm.ShowDialog();
                if (addEmployeeForm.DialogResult == DialogResult.OK)
                {
                    string name = addEmployeeForm.txtName.Text;
                    decimal salary;
                    decimal.TryParse(addEmployeeForm.txtInput1.Text, out salary);
                    decimal bonus;
                    decimal.TryParse(addEmployeeForm.txtInput2.Text, out bonus);
                    ShiftSupervisor employee = new ShiftSupervisor(name, counter, salary, bonus);
                    lstEmployeeList.Items.Add(employee);
                    counter++;
                }
            }

        }

        private void BtnAddTeamLead_Click(object sender, EventArgs e)
        {

            using (frmEmployee addEmployeeForm = new frmEmployee(3))
            {
                addEmployeeForm.ShowDialog();
                if (addEmployeeForm.DialogResult == DialogResult.OK)
                {
                    string name = addEmployeeForm.txtName.Text;
                    int shift, reqHrs, actHrs;
                    int.TryParse(addEmployeeForm.txtInput1.Text, out shift);
                    int.TryParse(addEmployeeForm.txtReqTrainHrs.Text, out reqHrs);
                    int.TryParse(addEmployeeForm.txtActTrainHrs.Text, out actHrs);
                    decimal pay, bonus;
                    decimal.TryParse(addEmployeeForm.txtInput2.Text, out pay);
                    decimal.TryParse(addEmployeeForm.txtMonthlyBonus.Text, out bonus);
                    TeamLeader employee = new TeamLeader(name, counter, shift, pay, bonus, reqHrs, actHrs);
                    lstEmployeeList.Items.Add(employee);
                    counter++;
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //Check for if TeamLeader before ProductionWorker
            //Because TeamLeader objs are ProductionWorker
            if (lstEmployeeList.SelectedItem is TeamLeader)
            {
                TeamLeader employee = (TeamLeader)lstEmployeeList.SelectedItem;
                using (frmEmployee editEmployeeForm = new frmEmployee(2))
                {
                    //Set form feilds to employees values
                    editEmployeeForm.txtName.Text = employee.EmpName;
                    editEmployeeForm.txtInput1.Text = employee.ShiftNumber.ToString();
                    editEmployeeForm.txtInput2.Text = employee.PayRate.ToString();
                    editEmployeeForm.txtReqTrainHrs.Text = employee.RequiredTrainingHours.ToString();
                    editEmployeeForm.txtActTrainHrs.Text = employee.ActualTrainingHours.ToString();
                    editEmployeeForm.txtMonthlyBonus.Text = employee.MonthlyBonus.ToString();
                    editEmployeeForm.ShowDialog();
                    if (editEmployeeForm.DialogResult == DialogResult.OK)
                    {
                        //Update employee information
                        string name = editEmployeeForm.txtName.Text;
                        int shift, reqHrs, actHrs;
                        int.TryParse(editEmployeeForm.txtInput1.Text, out shift);
                        int.TryParse(editEmployeeForm.txtReqTrainHrs.Text, out reqHrs);
                        int.TryParse(editEmployeeForm.txtActTrainHrs.Text, out actHrs);
                        decimal pay, bonus;
                        decimal.TryParse(editEmployeeForm.txtInput2.Text, out pay);
                        decimal.TryParse(editEmployeeForm.txtMonthlyBonus.Text, out bonus);
                        lstEmployeeList.Items.Remove(employee);
                        lstEmployeeList.Items.Add(employee);
                    }
                }
            }

            else if (lstEmployeeList.SelectedItem is ProductionWorker)
            {
                ProductionWorker employee = (ProductionWorker)lstEmployeeList.SelectedItem;
                using (frmEmployee editEmployeeForm = new frmEmployee(1))
                {
                    //Set form feilds to employees values
                    editEmployeeForm.txtName.Text = employee.EmpName;
                    editEmployeeForm.txtInput1.Text = employee.ShiftNumber.ToString();
                    editEmployeeForm.txtInput2.Text = employee.PayRate.ToString();
                    editEmployeeForm.ShowDialog();
                    if (editEmployeeForm.DialogResult == DialogResult.OK)
                    {
                        //Update employee information
                        string name = editEmployeeForm.txtName.Text;
                        int shift;
                        int.TryParse(editEmployeeForm.txtInput1.Text, out shift);
                        decimal pay;
                        decimal.TryParse(editEmployeeForm.txtInput2.Text, out pay);
                        employee.EmpName = name;
                        employee.ShiftNumber = shift;
                        employee.PayRate = pay;
                        lstEmployeeList.Items.Remove(employee);
                        lstEmployeeList.Items.Add(employee);
                    }
                }
            }

            else if (lstEmployeeList.SelectedItem is ShiftSupervisor)
            {
                ShiftSupervisor employee = (ShiftSupervisor)lstEmployeeList.SelectedItem;
                using (frmEmployee editEmployeeForm = new frmEmployee(2))
                {
                    //Set form feilds to employees values
                    editEmployeeForm.txtName.Text = employee.EmpName;
                    editEmployeeForm.txtInput1.Text = employee.AnnualSalary.ToString();
                    editEmployeeForm.txtInput2.Text = employee.AnnualProductionBonus.ToString();
                    editEmployeeForm.ShowDialog();
                    if (editEmployeeForm.DialogResult == DialogResult.OK)
                    {
                        //Update employee information
                        string name = editEmployeeForm.txtName.Text;
                        decimal salary;
                        decimal.TryParse(editEmployeeForm.txtInput1.Text, out salary);
                        decimal bonus;
                        decimal.TryParse(editEmployeeForm.txtInput2.Text, out bonus);
                        lstEmployeeList.Items.Remove(employee);
                        lstEmployeeList.Items.Add(employee);
                    }
                }
            }
            
        }
    }
}
