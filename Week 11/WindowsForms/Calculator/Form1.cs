using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private int input;

        private int product = 0;

        private string oldSign;

        private string newSign;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OperationButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            if (String.IsNullOrWhiteSpace(this.textBoxInput.Text))
            {
                MessageBox.Show("Using 0 as input");
                this.input = 0;
            }
            else
            {
                this.input = int.Parse(this.textBoxInput.Text);
            }

            this.textBoxResult.Text = this.input.ToString();
            switch (button.Text)
            {
                case "+":
                    this.newSign = "+";
                    this.CalculateSum();
                    //this.oldSign = "+";
                    break;
                case "-":
                    this.newSign = "-";
                    this.CalculateDifference();
                    break;
            }
            this.textBoxInput.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            this.textBoxInput.Text += button.Text;
        }

        private void CalculateSum()
        {
            this.textBoxResult.Text = (this.input + this.product).ToString();
            this.product = this.input + this.product;
        }

        private void CalculateDifference()
        {
            this.textBoxResult.Text = (this.input - this.product).ToString();
            this.product = this.input + this.product;
        }

        private void CalculateProduct()
        {
            this.textBoxResult.Text = (this.input * this.product).ToString();
            this.product = this.input + this.product;
        }

        private void CalculateDivision()
        {
            this.textBoxResult.Text = (this.product / this.input).ToString();
            this.product = this.input + this.product;
        }
    }
}
