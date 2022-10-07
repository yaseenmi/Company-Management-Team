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
    public partial class ADD_SKILL_FORM : Form
    {
        public static List<Skill> SkillNames = new List<Skill>();
        public ADD_SKILL_FORM()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Skill S = new Skill(textBox1.Text);
            SkillNames.Add(S);
            listBox1.Items.Add(S.SkillName);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            ADD_SKILL_FORM.SkillNames.RemoveAt(i);
            listBox1.Items.RemoveAt(i);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.IndianRed;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void ADD_SKILL_FORM_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
