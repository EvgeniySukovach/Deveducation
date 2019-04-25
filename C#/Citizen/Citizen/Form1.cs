using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citizen
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool action = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e){}

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || action)
                textBox.Clear();
            action = false;

            Button button = (Button)sender;

            if (button.Text == ",") {
                if (!textBox.Text.Contains(","))
                    textBox.Text = textBox.Text + button.Text;
                
            }
            else textBox.Text = textBox.Text + button.Text;

            //textBox.Text = textBox.Text + button.Text;
        }

        private void opetator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox.Text);
            action = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void calculate(object sender, EventArgs e)
        {
            switch (operation) {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
