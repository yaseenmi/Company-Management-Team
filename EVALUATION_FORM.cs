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
    public partial class EVALUATION_FORM : Form
    {
        public EVALUATION_FORM()
        {
            InitializeComponent();
        }

        private void EVALUATION_FORM_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team T in ADD_TEAM_FORM.Teams)
            {
                listBox1.Items.Add(T.TeamName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EVALUATE_EMPLOYEE EE = new EVALUATE_EMPLOYEE();
            EE.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            
            listBox2.Items.Clear();
            foreach(Employee j in ADD_TEAM_FORM.Teams[i].TeamMembers)
            {
                listBox2.Items.Add(j.EmployeeName);
            }
            
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EVALUATION_FORM_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
