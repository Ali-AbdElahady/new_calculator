using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_calculator
{
    public partial class Form1 : Form
    {
        string opr = "";
        double res = 0;
        bool isOpr = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_Click(object sender, EventArgs e)
        {
            Button but =(Button)sender;
            if (textBox1.Text == "0" || isOpr == true)
            {
                textBox1.Clear();
            }
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + but.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + but.Text;
            }
            isOpr = false;
                
        }

        private void opr_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (res != 0)
            {
                button19.PerformClick();
                opr = but.Text;
                res = double.Parse(textBox1.Text);
                isOpr = true;
            }
            else
            {
                opr = but.Text;
                res = double.Parse(textBox1.Text);
                isOpr = true;
            }
            
        }

        private void ecual_click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case "+":
                    textBox1.Text=(res + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text=(res - double.Parse(textBox1.Text)).ToString();
                    break ;
                case "*":
                    textBox1.Text = (res * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text =(res / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            res = 0;
        }
    }
}
