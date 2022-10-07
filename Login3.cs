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
    public partial class Login3 : Form
    {
        public Login3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ADD_SKILL_FORM ASF = new ADD_SKILL_FORM();
            if (textBox1.Text == "yaseen" && textBox2.Text == "12345")
            {
                ASF.Show();
            }
            else
                MessageBox.Show("incorrect password");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
                textBox2.PasswordChar = '*';
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightGreen;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
