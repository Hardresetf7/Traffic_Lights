using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(label1.Text);
         
            number++;

            label1.Text = number.ToString();

            if (number == 30)
            {
                button2.BackColor = Color.Yellow;
            }

            if (number == 40)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }

            if (number == 70)
            {
                number = 0;
                label1.Text = number.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
