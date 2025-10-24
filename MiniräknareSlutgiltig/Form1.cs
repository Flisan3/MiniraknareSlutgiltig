namespace MiniräknareSlutgiltig
{
    public partial class Form1 : Form
    {
        //Saves the latest number
        string newNumber = "";

        //Saves the total calculation as a number
        string totalNumber = "";

        //Saves the used operator
        char function;

        //Saves the buttons that are pressed as a string
        string userInput = "";

        //Used to set certain conditions before the first operator is used
        int x = 0;

        //Used to calculate with newNumber and totalNumber
        double temporary = 0.0;

        int error = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            // Adds the number to UserInput and displays UserInput
            textBox1.Text = "";
            userInput += "1";
            textBox1.Text += userInput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "2";
            textBox1.Text += userInput;
        }

        private void three_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            userInput += "3";
            textBox1.Text += userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "4";
            textBox1.Text += userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "5";
            textBox1.Text += userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "6";
            textBox1.Text += userInput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "7";
            textBox1.Text += userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "8";
            textBox1.Text += userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "9";
            textBox1.Text += userInput;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "0";
            textBox1.Text += userInput;
        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += ".";
            textBox1.Text += userInput;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput)) return;

            //Saves userinput to use for calculating
            newNumber = userInput;

            //Resets userinput
            userInput = "";

            //Condition for the first cycle, since there are no numbers to add.
            if (x == 0)
            {
                totalNumber = newNumber;
            }
            else
            {
                //Uses the saved operator from previous cycle and calculates based on what symbol function has stored
                if (function == '+')
                    temporary = double.Parse(totalNumber) + double.Parse(newNumber);
                else if (function == '-')
                    temporary = double.Parse(totalNumber) - double.Parse(newNumber);
                else if (function == '*')
                    temporary = double.Parse(totalNumber) * double.Parse(newNumber);
                else if (function == '/')
                {
                    if (double.Parse(newNumber) == 0)
                    {
                        error += 1;
                        return;
                    }
                    temporary = double.Parse(totalNumber) / double.Parse(newNumber);
                }

                totalNumber = temporary.ToString();
            }

            x += 1;

            //Saves the operator used
            function = '+';
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput)) return;

            //Saves userinput to use for calculating
            newNumber = userInput;

            //Resets userinput
            userInput = "";

            //Condition for the first cycle, since there are no numbers to subtract.
            if (x == 0)
            {
                totalNumber = newNumber;
            }
            else
            {
                //Uses the saved operator from previous cycle and calculates based on what symbol function has stored
                if (function == '+')
                    temporary = double.Parse(totalNumber) + double.Parse(newNumber);
                else if (function == '-')
                    temporary = double.Parse(totalNumber) - double.Parse(newNumber);
                else if (function == '*')
                    temporary = double.Parse(totalNumber) * double.Parse(newNumber);
                else if (function == '/')
                {
                    if (double.Parse(newNumber) == 0)
                    {
                        error += 1;
                        return;
                    }
                    temporary = double.Parse(totalNumber) / double.Parse(newNumber);
                }

                totalNumber = temporary.ToString();
            }

            x += 1;

            //Saves the operator used
            function = '-';
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput)) return;

            //Saves userinput to use for calculating
            newNumber = userInput;

            //Resets userinput
            userInput = "";

            //Condition for the first cycle, since there are no numbers to multiply.
            if (x == 0)
            {
                totalNumber = newNumber;
            }
            else
            {
                //Uses the saved operator from previous cycle and calculates based on what symbol function has stored
                if (function == '+')
                    temporary = double.Parse(totalNumber) + double.Parse(newNumber);
                else if (function == '-')
                    temporary = double.Parse(totalNumber) - double.Parse(newNumber);
                else if (function == '*')
                    temporary = double.Parse(totalNumber) * double.Parse(newNumber);
                else if (function == '/')
                {
                    if (double.Parse(newNumber) == 0)
                    {
                        error += 1;
                        return;
                    }
                    temporary = double.Parse(totalNumber) / double.Parse(newNumber);
                }

                totalNumber = temporary.ToString();
            }

            x += 1;

            //Saves the operator used
            function = '*';
        }

        private void divided_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput)) return;

            //Saves userinput to use for calculating
            newNumber = userInput;

            //Resets userinput
            userInput = "";

            //Condition for the first cycle, since there are no numbers to divide.
            if (x == 0)
            {
                totalNumber = newNumber;
            }
            else
            {
                //Uses the saved operator from previous cycle and calculates based on what symbol function has stored
                if (function == '+')
                    temporary = double.Parse(totalNumber) + double.Parse(newNumber);
                else if (function == '-')
                    temporary = double.Parse(totalNumber) - double.Parse(newNumber);
                else if (function == '*')
                    temporary = double.Parse(totalNumber) * double.Parse(newNumber);
                else if (function == '/')
                {
                    if (double.Parse(newNumber) == 0)
                    {
                        error += 1;
                        return;
                    }
                    temporary = double.Parse(totalNumber) / double.Parse(newNumber);
                }

                totalNumber = temporary.ToString();
            }

            x += 1;

            //Saves the operator used
            function = '/';
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput)) return;

            //Saves userinput to use for calculating
            newNumber = userInput;

            //Uses the saved operator from previous cycle and calculates based on what symbol function has stored
            if (function == '+')
                temporary = double.Parse(totalNumber) + double.Parse(newNumber);
            else if (function == '-')
                temporary = double.Parse(totalNumber) - double.Parse(newNumber);
            else if (function == '*')
                temporary = double.Parse(totalNumber) * double.Parse(newNumber);
            else if (function == '/')
            {
                if (double.Parse(newNumber) == 0)
                {
                    error += 1;
                    textBox1.Text = "Error";
                    return;
                }
                temporary = double.Parse(totalNumber) / double.Parse(newNumber);
            }

            //Display answer
            if (error != 0)
            {
                textBox1.Text = "Error";
                return;
            }
            else
            {
                textBox1.Text = temporary.ToString();
            }

            //Reset saved numbers
            totalNumber = temporary.ToString();
            newNumber = "";
            userInput = "";
            x = 0;
            error = 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Reset everything
            newNumber = "";
            totalNumber = "";
            userInput = "";
            x = 0;
            temporary = 0.0;
            textBox1.Text = "0";
            error = 0;
        }
    }
}
