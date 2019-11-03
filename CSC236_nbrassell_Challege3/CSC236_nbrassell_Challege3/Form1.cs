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
    public partial class frmMain : Form
    {
        private List<Student> students = new List<Student>();

        public frmMain()
        {
            InitializeComponent();
        }

        //Opens an Add Student form, gets data from that form and adds a student to the list if the user click the OK button
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using(var addStudentForm = new frmAddStudent())
            {
                addStudentForm.ShowDialog();
                if (addStudentForm.DialogResult == DialogResult.OK)
                {
                    Student student = new Student(addStudentForm.StudentName, addStudentForm.Scores);
                    students.Add(student);
                    lstStudents.Items.Add(student);
                }
            }
        }

        //Displays total, average and number of scores for selected student
        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)lstStudents.SelectedItem;
            if (student != null)
            {
                lblTotal.Text = student.ScoreTotal.ToString();
                lblCount.Text = student.ScoreCount.ToString();
                lblAverage.Text = student.ScoreAverage.ToString();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Student student = (Student)lstStudents.SelectedItem;

            using (var updateStudentForm = new frmUpdateStudent(student))
            {
                updateStudentForm.ShowDialog();
                if (updateStudentForm.DialogResult == DialogResult.OK)
                {
                    student.ScoresList = updateStudentForm.Scores;
                    lstStudents.Items.Remove(student);
                    lstStudents.Items.Add(student);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                List<int> exampleScores = new List<int>();
                exampleScores.AddRange(new int[]
                {
                    98,
                    89,
                    90
                });
                Student student = new Student($"Example Student{i+1}", exampleScores);
                students.Add(student);
            }
            foreach (var student in students)
            {
                lstStudents.Items.Add(student);
            }
        }
    }
}
