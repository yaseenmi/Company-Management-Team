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
    public partial class ADD_EMPLOYEE_FORM : Form
    {
        public static List<Employee> Employees = new List<Employee>();
        public ADD_EMPLOYEE_FORM()
        {
            InitializeComponent();
        }

        private void ADD_EMPLOYEE_FORM_Load(object sender, EventArgs e)
        {
            Login2 Log2 = new Login2();
            Log2.Hide();
            groupBox1.Visible = false;
            listBox1.Items.Clear();
            foreach (Team T in ADD_TEAM_FORM.Teams)
            {
                listBox1.Items.Add(T.TeamName);
            }


        }

        public  void button5_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            RadioButton R = new RadioButton();
            Employee E = new Employee(textBox1.Text , Convert.ToDecimal (textBox2.Text) , Convert.ToInt32 (comboBox1.SelectedValue) , new Position (R.Checked , textBox4.Text ,  Convert.ToDecimal(textBox5.Text) , Convert.ToDecimal (textBox6.Text)));
            Employees.Add(E);
            ADD_TEAM_FORM.Teams.ElementAt<Team>(i).TeamMembers.Add(E);
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton R = new RadioButton();
            if (radioButton2.Checked  && groupBox1.Visible == false)
            {
                groupBox1.Text = radioButton2.Text;
                groupBox1.Visible = true;
            }
            if (radioButton2.Checked == false && groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && groupBox1.Visible == false)
            {
                groupBox1.Text = radioButton3.Text;
                groupBox1.Visible = true;
            }

            if (radioButton3.Checked == false && groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && groupBox1.Visible == false)
            {
                groupBox1.Text = radioButton4.Text;
                groupBox1.Visible = true;
            }
            if (radioButton4.Checked == false && groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked && groupBox1.Visible == false)
            {
                groupBox1.Text = radioButton5.Text;
                groupBox1.Visible = true;
            }
            if (radioButton5.Checked == false && groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
