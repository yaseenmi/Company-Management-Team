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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login2 Log2 = new Login2();
            Log2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login3 Log3 = new Login3();
            Log3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EVALUATION_FORM EF = new EVALUATION_FORM();
            EF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VIEW_EVALUATION_FORM VEF = new VIEW_EVALUATION_FORM();
            VEF.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSeaGreen;
            button1.Height = 70;
            button1.Width = 250;
            if (label2.Visible == false)
            {
                label2.Text = "Step1 : Add Teams to list";
                label2.Visible = true;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.Height = 58;
            button1.Width = 212;
            label2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSeaGreen;
            button2.Height = 70;
            button2.Width = 250;
            if (label3.Visible == false)
            {
                label3.Text = "Step2 : Add Employees to each team";
                label3.Visible = true;
            }
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.Height = 58;
            button2.Width = 212;
            label3.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSeaGreen;
            button3.Height = 70;
            button3.Width = 250;
            if (label4.Visible == false)
            {
                label4.Text = "Step3 : Add skills list";
                label4.Visible = true;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.Height = 58;
            button3.Width = 212;
            label4.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightSeaGreen;
            button4.Height = 70;
            button4.Width = 250;
            if (label5.Visible == false)
            {
                label5.Text = "Step4 : Evaluate each employee and rate him";
                label5.Visible = true;
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.Height = 58;
            button4.Width = 212;
            label5.Visible = false;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightSeaGreen;
            button6.Height = 70;
            button6.Width = 250;
            if (label6.Visible == false)
            {
                label6.Text = "Step5 : View all evaluation for each employee";
                label6.Visible = true;
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.Height = 58;
            button6.Width = 212;
            label6.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.IndianRed;
            button5.Height = 70;
            button5.Width = 250;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.Height = 58;
            button5.Width = 212;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (label7.Visible == false)
            {
                label7.Visible = true;
            }

            pictureBox1.Height = 45;
            pictureBox1.Width = 45;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
            pictureBox1.Height = 42;
            pictureBox1.Width = 42;
        }
    }
}
