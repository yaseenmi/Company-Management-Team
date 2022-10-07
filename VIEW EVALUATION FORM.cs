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
    public partial class VIEW_EVALUATION_FORM : Form
    {
        public VIEW_EVALUATION_FORM()
        {
            InitializeComponent();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.IndianRed;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VIEW_EVALUATION_FORM_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Employee E in ADD_EMPLOYEE_FORM.Employees)
            {
                listBox1.Items.Add(E.EmployeeName);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            listBox2.Items.Clear();
            foreach (Review_ j in ADD_EMPLOYEE_FORM.Employees[i].Re)
            {
                listBox2.Items.Add(j.Review);
            }
        }
    }
}
