using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mid_Programs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(f_number.Text); // f_number is the name of textbox
            int fact = number;

            

            for (int i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            if (fact == 0)
            {
                fact = 1;
            }


            f_result.Text = fact.ToString();
        }

        private void check_even_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(e_number.Text);
            String res;

            if (num % 2 == 0)
            {
                res = "Even";
            }
            else
            {
                res = "Odd";
            }

            e_result.Text = res;
            //MessageBox.Show("Number is: " + res);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(your_age.Text);
            int res = num * 365;

            age_textbox_res.Text = res.ToString();
        }

        
    }
}
