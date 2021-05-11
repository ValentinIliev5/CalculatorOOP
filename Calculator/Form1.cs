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
    public partial class CalculatorForm : Form
    {
        Stack<double> MemoryStack = new Stack<double>();





        public CalculatorForm()
        {
            InitializeComponent();
        }




        private void OneButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "1";
            }
            else
            {
                CurrentNumberLabel.Text = "1";
            }
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(CurrentNumberLabel.Text);
            CurrentNumberLabel.Text = (number * (-1)).ToString();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "0";
            }
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "2";
            }
            else
            {
                CurrentNumberLabel.Text = "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "3";
            }
            else
            {
                CurrentNumberLabel.Text = "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "4";
            }
            else
            {
                CurrentNumberLabel.Text = "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "5";
            }
            else
            {
                CurrentNumberLabel.Text = "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "6";
            }
            else
            {
                CurrentNumberLabel.Text = "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "7";
            }
            else
            {
                CurrentNumberLabel.Text = "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "8";
            }
            else
            {
                CurrentNumberLabel.Text = "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + "9";
            }
            else
            {
                CurrentNumberLabel.Text = "9";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

            if (!PreviousNumberLabel.Visible)
            {
                PreviousNumberLabel.Visible = true;
                PreviousNumberLabel.Text = CurrentNumberLabel.Text + " " + PlusButton.Text;
            }
            else
            {
                if (PreviousNumberLabel.Text[PreviousNumberLabel.Text.Length - 1] != '=')
                {


                    var getText = PreviousNumberLabel.Text.Split(' ').ToList();

                    double firstNumber = double.Parse(getText[0]);
                    string operation = getText[1];
                    double secondNumber = double.Parse(CurrentNumberLabel.Text);


                    switch (operation)
                    {
                        case "+":
                            CurrentNumberLabel.Text = (firstNumber + secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber + secondNumber).ToString() + " +";
                            break;


                        case "-":
                            CurrentNumberLabel.Text = (firstNumber - secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber - secondNumber).ToString() + " +";
                            break;


                        case "x":
                            CurrentNumberLabel.Text = (firstNumber * secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber * secondNumber).ToString() + " +";
                            break;


                        case "÷":
                            if (secondNumber == 0)
                            {
                                MessageBox.Show("Sorry, no division by zero");
                                CurrentNumberLabel.Text = "0";
                                PreviousNumberLabel.Text = "";
                                PreviousNumberLabel.Visible = false;
                                return;
                            }
                            CurrentNumberLabel.Text = (firstNumber / secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber / secondNumber).ToString() + " +";
                            break;


                        default: break;
                    }

                }
                else
                {
                    PreviousNumberLabel.Text = CurrentNumberLabel.Text + " +";
                }

            }
            CurrentNumberLabel.Text = "0";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

            PreviousNumberLabel.Visible = true;
            double firstNumber, secondNumber;
            string operation;
            var getText = PreviousNumberLabel.Text.Split(' ').ToList();
            if (getText[getText.Count - 1] != "=")
            {
                firstNumber = double.Parse(getText[0]);
                operation = getText[1];
                secondNumber = double.Parse(CurrentNumberLabel.Text);


            }
            else
            {
                firstNumber = double.Parse(CurrentNumberLabel.Text);
                operation = getText[1];
                secondNumber = double.Parse(getText[2]);


            }

            switch (operation)
            {
                case "+":
                    CurrentNumberLabel.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    CurrentNumberLabel.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "x":
                    CurrentNumberLabel.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "÷":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Sorry, no division by zero");
                        CurrentNumberLabel.Text = "0";
                        PreviousNumberLabel.Text = "";
                        PreviousNumberLabel.Visible = false;
                        return;
                    }
                    CurrentNumberLabel.Text = (firstNumber / secondNumber).ToString();
                    break;

                default: break;
            }
            PreviousNumberLabel.Text = firstNumber.ToString() + " " + operation + " " + secondNumber.ToString() + " =";


        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (!PreviousNumberLabel.Visible)
            {
                PreviousNumberLabel.Visible = true;
                PreviousNumberLabel.Text = CurrentNumberLabel.Text + " " + MinusButton.Text;
            }
            else
            {
                if (PreviousNumberLabel.Text[PreviousNumberLabel.Text.Length - 1] != '=')
                {


                    var getText = PreviousNumberLabel.Text.Split(' ').ToList();

                    double firstNumber = double.Parse(getText[0]);
                    string operation = getText[1];
                    double secondNumber = double.Parse(CurrentNumberLabel.Text);


                    switch (operation)
                    {
                        case "+":
                            CurrentNumberLabel.Text = (firstNumber + secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber + secondNumber).ToString() + " -";
                            break;


                        case "-":
                            CurrentNumberLabel.Text = (firstNumber - secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber - secondNumber).ToString() + " -";
                            break;


                        case "x":
                            CurrentNumberLabel.Text = (firstNumber * secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber * secondNumber).ToString() + " -";
                            break;


                        case "÷":
                            if (secondNumber == 0)
                            {
                                MessageBox.Show("Sorry, no division by zero");
                                CurrentNumberLabel.Text = "0";
                                PreviousNumberLabel.Text = "";
                                PreviousNumberLabel.Visible = false;
                                return;
                            }
                            CurrentNumberLabel.Text = (firstNumber / secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber / secondNumber).ToString() + " -";
                            break;


                        default: break;
                    }

                }
                else
                {
                    PreviousNumberLabel.Text = CurrentNumberLabel.Text + " -";
                }

            }
            CurrentNumberLabel.Text = "0";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (!PreviousNumberLabel.Visible)
            {
                PreviousNumberLabel.Visible = true;
                PreviousNumberLabel.Text = CurrentNumberLabel.Text + " " + MultiplyButton.Text.ToLower();
            }
            else
            {
                if (PreviousNumberLabel.Text[PreviousNumberLabel.Text.Length - 1] != '=')
                {


                    var getText = PreviousNumberLabel.Text.Split(' ').ToList();

                    double firstNumber = double.Parse(getText[0]);
                    string operation = getText[1];
                    double secondNumber = double.Parse(CurrentNumberLabel.Text);


                    switch (operation)
                    {
                        case "+":
                            CurrentNumberLabel.Text = (firstNumber + secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber + secondNumber).ToString() + " x";
                            break;


                        case "-":
                            CurrentNumberLabel.Text = (firstNumber - secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber - secondNumber).ToString() + " x";
                            break;


                        case "x":
                            CurrentNumberLabel.Text = (firstNumber * secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber * secondNumber).ToString() + " x";
                            break;


                        case "÷":
                            if (secondNumber == 0)
                            {
                                MessageBox.Show("Sorry, no division by zero");
                                CurrentNumberLabel.Text = "0";
                                PreviousNumberLabel.Text = "";
                                PreviousNumberLabel.Visible = false;
                                return;
                            }
                            CurrentNumberLabel.Text = (firstNumber / secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber / secondNumber).ToString() + " x";
                            break;


                        default: break;
                    }

                }
                else
                {
                    PreviousNumberLabel.Text = CurrentNumberLabel.Text + " x";
                }

            }
            CurrentNumberLabel.Text = "0";
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (!PreviousNumberLabel.Visible)
            {
                PreviousNumberLabel.Visible = true;
                PreviousNumberLabel.Text = CurrentNumberLabel.Text + " ÷";
            }
            else
            {
                if (PreviousNumberLabel.Text[PreviousNumberLabel.Text.Length - 1] != '=')
                {


                    var getText = PreviousNumberLabel.Text.Split(' ').ToList();

                    double firstNumber = double.Parse(getText[0]);
                    string operation = getText[1];
                    double secondNumber = double.Parse(CurrentNumberLabel.Text);


                    switch (operation)
                    {
                        case "+":
                            CurrentNumberLabel.Text = (firstNumber + secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber + secondNumber).ToString() + " ÷";
                            break;


                        case "-":
                            CurrentNumberLabel.Text = (firstNumber - secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber - secondNumber).ToString() + " ÷";
                            break;


                        case "x":
                            CurrentNumberLabel.Text = (firstNumber * secondNumber).ToString();
                            PreviousNumberLabel.Text = (firstNumber * secondNumber).ToString() + " ÷";
                            break;


                        case "÷":
                            if (secondNumber == 0)
                            {
                                MessageBox.Show("Sorry, no division by zero");
                                CurrentNumberLabel.Text = "0";
                                PreviousNumberLabel.Text = "";
                                PreviousNumberLabel.Visible = false;
                                return;
                            }
                            CurrentNumberLabel.Text = (firstNumber / secondNumber).ToString();

                            PreviousNumberLabel.Text = (firstNumber / secondNumber).ToString() + " ÷";
                            break;


                        default: break;
                    }

                }
                else
                {
                    PreviousNumberLabel.Text = CurrentNumberLabel.Text + " ÷";
                }

            }
            CurrentNumberLabel.Text = "0";
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            CurrentNumberLabel.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CurrentNumberLabel.Text = "0";
            PreviousNumberLabel.Text = "";
            PreviousNumberLabel.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (CurrentNumberLabel.Text != "0")
            {
                if (CurrentNumberLabel.Text.Length == 1)
                {
                    CurrentNumberLabel.Text = "0";
                }
                else
                {
                    CurrentNumberLabel.Text = CurrentNumberLabel.Text.Substring(0, CurrentNumberLabel.Text.Length - 1);
                    if (CurrentNumberLabel.Text == "-")
                    {
                        CurrentNumberLabel.Text = "0";
                    }
                }
            }
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(CurrentNumberLabel.Text);
            PreviousNumberLabel.Text = $"sqrt({CurrentNumberLabel.Text})";
            PreviousNumberLabel.Visible = true;
            CurrentNumberLabel.Text = Math.Sqrt(number).ToString();
        }

        private void SquaredButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(CurrentNumberLabel.Text);
            PreviousNumberLabel.Text = $"sqr({CurrentNumberLabel.Text})";
            PreviousNumberLabel.Visible = true;
            CurrentNumberLabel.Text = Math.Pow(number, 2).ToString();
        }

        private void ReverseNumberButton_Click(object sender, EventArgs e)
        {
            double number = double.Parse(CurrentNumberLabel.Text);
            PreviousNumberLabel.Text = $"1/({CurrentNumberLabel.Text})";
            PreviousNumberLabel.Visible = true;
            CurrentNumberLabel.Text = (1 / number).ToString();
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            double percentNumber = double.Parse(CurrentNumberLabel.Text);
            double oldNumber = double.Parse(PreviousNumberLabel.Text.Split(' ')[0]);
            PreviousNumberLabel.Text = PreviousNumberLabel.Text + " " + oldNumber * (percentNumber / 100);
            PreviousNumberLabel.Visible = true;
            CurrentNumberLabel.Text = (oldNumber * (percentNumber / 100)).ToString();
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (!CurrentNumberLabel.Text.Contains('.'))
            {
                CurrentNumberLabel.Text = CurrentNumberLabel.Text + ".";
            }
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            MemoryStack.Clear();
            MemoryBox.Items.Clear();
        }

        private void MemoryRecallButton_Click(object sender, EventArgs e)
        {
            if (MemoryStack.Count == 0)
            {
                MessageBox.Show("No numbers in the memory");
            }
            else
            {
                CurrentNumberLabel.Text = MemoryStack.Peek().ToString();
            }
        }

        private void MemoryPlusButton_Click(object sender, EventArgs e)
        {
            if (MemoryStack.Count == 0)
            {
                MemoryStack.Push(double.Parse(CurrentNumberLabel.Text));
            }
            else
            {
                MemoryStack.Push(MemoryStack.Pop() + double.Parse(CurrentNumberLabel.Text));
            }
            UpdateItems();
        }

        private void MemoryMinusButton_Click(object sender, EventArgs e)
        {
            if (MemoryStack.Count == 0)
            {
                MemoryStack.Push(double.Parse(CurrentNumberLabel.Text));
            }
            else
            {
                MemoryStack.Push(MemoryStack.Pop() - double.Parse(CurrentNumberLabel.Text));
            }
            UpdateItems();
        }


        private void ShowMemoryButton_Click(object sender, EventArgs e)
        {
            MemoryBox.Visible = !MemoryBox.Visible;
        }



        private void MemorySaveButton_Click(object sender, EventArgs e)
        {
            MemoryStack.Push(double.Parse(CurrentNumberLabel.Text));
            UpdateItems();
        }


        private void UpdateItems()
        {
            MemoryBox.Items.Clear();
            foreach (var item in MemoryStack)
            {
                MemoryBox.Items.Add(item.ToString());
            }
        }

        private void MemoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentNumberLabel.Text = MemoryBox.SelectedItem.ToString();
            MemoryBox.Visible = false;
        }
    }
}
