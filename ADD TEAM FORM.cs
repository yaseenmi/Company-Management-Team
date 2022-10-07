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
    public partial class ADD_TEAM_FORM : Form
    {
        public static  List<Team> Teams = new List<Team>();
        public ADD_TEAM_FORM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Team T = new Team(textBox1.Text, dateTimePicker1.Value);
            Teams.Add(T);
            listBox1.Items.Add(T.TeamName);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void ADD_TEAM_FORM_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            Teams.RemoveAt(i);
            listBox1.Items.RemoveAt(i);

        }
    }
}
