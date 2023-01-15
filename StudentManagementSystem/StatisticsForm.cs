using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        //Colour variables
        public Color panelTotalColor;
        public Color panelMaleColor;
        public Color panelFemaleColor;
        private void StatisticsForm_Load(object sender, EventArgs e)
        {

            //get the panels back colors
            panelTotalColor = panelTotal.BackColor;
            panelMaleColor = panelMale.BackColor;
            panelFemaleColor = panelFemale.BackColor;

            //display the values
            Student student = new Student();
            double totalStudents = Convert.ToDouble(student.totalStudent());
            double totalMaleStudents = Convert.ToDouble(student.totalMaleStudent());
            double totalFemaleStudents = Convert.ToDouble(student.totalFemaleStudent());

            //Count the %
            double malePercentage = totalMaleStudents * 100 / totalStudents;
            double FemalePercentage = totalFemaleStudents * 100 / totalStudents;

            labelTotal.Text = "Total Students: " + totalStudents.ToString();
            labelMale.Text = "Male: "+ malePercentage.ToString("0.0") + "%";
            labelFemale.Text = "Female: " + FemalePercentage.ToString("0.0")+"%";

        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panelTotalColor;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panelTotalColor;
            labelTotal.ForeColor = Color.White;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = panelMaleColor;
            labelMale.ForeColor = Color.White;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.White;
            labelMale.ForeColor = panelMaleColor;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.White;
            labelFemale.ForeColor = panelFemaleColor;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = panelFemaleColor;
            labelFemale.ForeColor = Color.White;
        }
    }
}
