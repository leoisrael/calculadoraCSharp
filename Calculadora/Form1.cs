using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calcCLib;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string first = "0";
        string second = "0";
        string function = "";
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "1";
            lblDisplay.Text += userInput;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "2";
            lblDisplay.Text += userInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "3";
            lblDisplay.Text += userInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "4";
            lblDisplay.Text += userInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "5";
            lblDisplay.Text += userInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "6";
            lblDisplay.Text += userInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "7";
            lblDisplay.Text += userInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "8";
            lblDisplay.Text += userInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "9";
            lblDisplay.Text += userInput;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            userInput += "0";
            lblDisplay.Text += userInput;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            first = "0";
            second = "0";
            userInput = "";
            result = 0.0;
            lblDisplay.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            function = "+";
            first = userInput;
            userInput = "";
            lblDisplay.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            function = "-";
            first = userInput;
            userInput = "";
            lblDisplay.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            function = "/";
            first = userInput;
            userInput = "";
            lblDisplay.Text = "";
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            function = "!";
            first = userInput;
            userInput = "";
            lblDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            second = userInput;
            string[] calc = new string[3]; 
            calc[0] = function;
            calc[1] = first.ToString();
            calc[2] = second.ToString();            
            AutoCalcObject calcO = new AutoCalcObject(calc);
            result = Convert.ToDouble(calcO.Print());
            first = "";
            second = "";
            userInput = "";
            function = "";
            lblDisplay.Text = result.ToString();
        }
    }
}
