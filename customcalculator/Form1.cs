namespace customcalculator
{
    public partial class Form1 : Form
    {

        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void PeriodButton_Click(object sender, EventArgs e)
        {
            if (!OutputTextBox.Text.Contains("."))
            {
                OutputTextBox.Text += ".";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {

                OutputTextBox.Text = "0";
            }
            else
            {
                OutputTextBox.Text += "0";
            }
        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "1";
            }
            else
            {
                OutputTextBox.Text += "1";
            }

        }


        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "2";
            }
            else
            {
                OutputTextBox.Text += "2";
            }

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "3";
            }
            else
            {
                OutputTextBox.Text += "3";
            }

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "4";
            }
            else
            {
                OutputTextBox.Text += "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "5";
            }
            else
            {
                OutputTextBox.Text += "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "6";
            }
            else
            {
                OutputTextBox.Text += "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "7";
            }
            else
            {
                OutputTextBox.Text += "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "8";
            }
            else
            {
                OutputTextBox.Text += "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "9";
            }
            else
            {
                OutputTextBox.Text += "9";
            }
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(OutputTextBox.Text);
            OutputTextBox.Clear();
            operators = "-";
        }

        private void IDKButton_Click(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.Contains("-"))
            {
                OutputTextBox.Text = OutputTextBox.Text.Trim('-');
            }
            else
            {
                OutputTextBox.Text = "-" + OutputTextBox.Text;
            }
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(OutputTextBox.Text);
            OutputTextBox.Clear();
            operators = "+";
        }

        private void SlashButton_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(OutputTextBox.Text);
            OutputTextBox.Clear();
            operators = "/";
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(OutputTextBox.Text);
            OutputTextBox.Clear();
            operators = "x";
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(OutputTextBox.Text);
            OutputTextBox.Clear();
            operators = "%";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(OutputTextBox.Text);
                    Result = valueFirst - valueSecond;
                    OutputTextBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(OutputTextBox.Text);
                    Result = valueFirst + valueSecond;
                    OutputTextBox.Text = Result.ToString();
                    break;
                case "x":
                    valueSecond = decimal.Parse(OutputTextBox.Text);
                    Result = valueFirst * valueSecond;
                    OutputTextBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(OutputTextBox.Text);
                    Result = valueFirst / valueSecond;
                    OutputTextBox.Text = Result.ToString();
                    break;
                case "%":
                    valueSecond = decimal.Parse(OutputTextBox.Text);
                    Result = valueFirst % valueSecond;
                    OutputTextBox.Text = Result.ToString();
                    break;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            OutputTextBox.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RickRoll_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }

}
