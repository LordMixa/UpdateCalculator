using System;
using System.Windows.Forms;

namespace WFACalculator
{
    public partial class Form1 : Form
    {

        public double result { get; set; }

        bool plusActive, minusActive, divideActive, multiplyActive = false;
        string history;
        public Form1()
        {
            InitializeComponent();
            textBoxResult.Text = "0";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button1.Text;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button2.Text;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button3.Text;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button4.Text;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button5.Text;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button6.Text;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button7.Text;
        }

        public void button8_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button8.Text;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button9.Text;
        }

        public void button0_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button0.Text;
        }

        public void buttonPlus_Click(object sender, EventArgs e)
        {
            operationFinisher();
            plusActive = true;
            textBoxOperation.Text = "+";
        }

        public void buttonMinus_Click(object sender, EventArgs e)
        {
            operationFinisher();
            minusActive = true;
            textBoxOperation.Text = "-";
        }

        public void buttonMultiply_Click(object sender, EventArgs e)
        {
            operationFinisher();
            multiplyActive = true;
            textBoxOperation.Text = "*";
        }

        public void buttonDivide_Click(object sender, EventArgs e)
        {
            operationFinisher();
            divideActive = true;
            textBoxOperation.Text = "/";
        }

        public void buttonEquals_Click(object sender, EventArgs e)
        {
            operationFinisher();
        }

        public void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += ",";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text != "")
            {
                string numberAsString = textBoxValue.Text;
                numberAsString = numberAsString.Substring(0, numberAsString.Length - 1);
                textBoxValue.Text = numberAsString;
            }
        }

        public void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text.StartsWith("-"))
                textBoxValue.Text = textBoxValue.Text.Substring(1);
            else
                textBoxValue.Text = "-" + textBoxValue.Text;
        }

        public void buttonPercantage_Click(object sender, EventArgs e)
        {
            if(textBoxValue.Text != "")
                textBoxValue.Text = (0.01*double.Parse(textBoxValue.Text)).ToString();
        }

        public void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(history);
        }

        public void buttonClear_Click(object sender, EventArgs e)
        {
            cE();
        }
        public void operationFinisher()
        {
            if (plusActive && textBoxValue.Text != "")
            {
                history += textBoxResult.Text + textBoxOperation.Text+ textBoxValue.Text+"=";
                result += double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                history += textBoxResult.Text+'\n';
                textBoxOperation.Clear();
                textBoxValue.Clear();
                plusActive = false;
            }
            else if (minusActive && textBoxValue.Text != "")
            {
                history += textBoxResult.Text + textBoxOperation.Text + textBoxValue.Text + "=";
                result -= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                history += textBoxResult.Text + '\n';
                textBoxOperation.Clear();
                textBoxValue.Clear();
                minusActive = false;
            }
            else if (divideActive && textBoxValue.Text != "")
            {
                history += textBoxResult.Text + textBoxOperation.Text + textBoxValue.Text + "=";
                result /= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                history += textBoxResult.Text + '\n';
                textBoxOperation.Clear();
                textBoxValue.Clear();
                divideActive = false;
            }
            else if (multiplyActive && textBoxValue.Text != "")
            {
                history += textBoxResult.Text + textBoxOperation.Text + textBoxValue.Text + "=";
                result *= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                history += textBoxResult.Text + '\n';
                textBoxOperation.Clear();
                textBoxValue.Clear();
                multiplyActive = false;
            }
            else if (textBoxValue.Text!="")
            {
                result = double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxValue.Clear();
            }
        }
        public void cE()
        {
            textBoxOperation.Clear();
            textBoxResult.Text = "0";
            textBoxValue.Clear();
            result = 0;
            multiplyActive = false; divideActive = false; minusActive = false; plusActive = false;
        }
    }
}
