using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2___Project1
{
    public partial class EVALUATE_EMPLOYEE : Form
    {
        
        public EVALUATE_EMPLOYEE()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EVALUATION_FORM EF = new EVALUATION_FORM();

            Review_ R_ = new Review_();
            R_.SetOfEmployeeSkills = checkedListBox1.CheckedItems.OfType<Skill>().ToList();
            Review_ R = new Review_(richTextBox1.Text, R_.SetOfEmployeeSkills ,Convert.ToInt32( comboBox1.SelectedItem));
            int i = listBox1.SelectedIndex;
            ADD_EMPLOYEE_FORM.Employees.ElementAt<Employee>(i).Re.Add(R);
        }

        private void EVALUATE_EMPLOYEE_Load(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            foreach(Skill S in ADD_SKILL_FORM.SkillNames)
            {
                checkedListBox1.Items.Add(S.SkillName);
            }
            listBox1.Items.Clear();
            foreach (Employee l in ADD_EMPLOYEE_FORM.Employees)
            {
                listBox1.Items.Add(l.EmployeeName);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
