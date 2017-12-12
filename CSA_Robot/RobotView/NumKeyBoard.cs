using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class KeyBoard : Form
    {


        public KeyBoard()
        {
            InitializeComponent();
        }

        public static decimal ShowBox(decimal oldNumber, decimal minNumber, decimal maxNumber)
        {
            KeyBoard keyBoard = new KeyBoard();
            keyBoard.OldNumber = oldNumber;
            keyBoard.MinNumber = minNumber;
            keyBoard.MaxNumber = maxNumber;
            keyBoard.ShowDialog();

            return keyBoard.Result;
        }

        public decimal OldNumber { get; set; }

        public decimal MaxNumber { get; set; }

        public decimal MinNumber { get; set; }

        public decimal Result { get; set; }

        public bool Negation { get; set; }

        private decimal getResult()
        {
            if (textBoxDisplay.Text.Length != 0)
            {
                if (this.Negation)
                {
                    return decimal.Negate(Convert.ToDecimal(textBoxDisplay.Text));
                }
                else
                {
                    return Convert.ToDecimal(textBoxDisplay.Text);
                }
            }
            else
            {
                return 0;
            }
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (textBoxDisplay.Text.Length != 0)
            {
                decimal tempResult = getResult();
                if (tempResult < this.MinNumber)
                {
                    buttonBack_Click(null, EventArgs.Empty);
                    labelError.Text = "minimaler Wert: " + this.MinNumber;
                    labelError.ForeColor = Color.Red;
                }
                if (tempResult > this.MaxNumber)
                {
                    buttonBack_Click(null, EventArgs.Empty);
                    labelError.Text = "maximaler Wert: " + this.MaxNumber;
                    labelError.ForeColor = Color.Red;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            if (this.Negation)
            {
                buttonChangeSign_Click(null, EventArgs.Empty);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length != 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length != 0)
            {
                textBoxDisplay.Text += "0";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Result = getResult();
            this.Close();
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (this.Negation)
            {
                this.Negation = false;
                this.textBoxSign.Text = "";
            }
            else
            {
                this.Negation = true;
                this.textBoxSign.Text = "-";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Result = OldNumber;
            this.Close();
        }

        private void buttonAdd10_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() + 10).ToString();
        }

        private void buttonAdd100_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() + 100).ToString();
        }

        private void buttonAdd1000_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() + 1000).ToString();
        }

        private void buttonRemove10_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() - 10).ToString();
        }

        private void buttonRemove100_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() - 100).ToString();
        }

        private void buttonRemove1000_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = (getResult() - 1000).ToString();
        }
    }
}