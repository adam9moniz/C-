using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The following fields are used to store the value that's currently
        // displayed by the calculator. displayString is a string value that's
        // constructed as the user clicks numeric keys and the decimal and +/-
        // key. The Convert.ToDecimal method is then used to convert this to a decimal
        // field that's stored in displayValue.
        private string displayString;
        private decimal displayValue;

        // The following boolean fields are used to control numeric entry.
        // newValue indicates whether the calculator is ready to receive a
        // new number. Once the user clicks a digit button, newValue is
        // set to false. When the user clicks a button that "enters" the value, 
        // such as Add or Equals, newValue is set to true so the user can enter 
        // another value.
        // decimalEntered is used to restrict the entry to a single decimal point.
        // It is set to true whenever newValue is set to true, and it is set to 
        // false whenever the user clicks the decimal point button.
        private bool newValue;
        private bool decimalEntered;

        private Calculator calc = new Calculator(); //creates the new calulator object

        private void Form1_Load(object sender, System.EventArgs e)
        {
            displayValue = 0;
            displayString = displayValue.ToString();
            newValue = true;
            decimalEntered = false;
        }

        // This method handles the 0 through 9 keys, appending the digit clicked
        // to the displayString field. 
        private void btnNumber_Click(object sender, System.EventArgs e)
        {
            if (newValue)
            {
                displayString = "";
                newValue = false;
            }
            displayString += ((Button)sender).Tag.ToString();
            displayValue = Convert.ToDecimal(displayString);
            txtDisplay.Text = displayValue.ToString();
        }

        // This method removes the last character from the displayString field.
        private void btnBackSpace_Click(object sender, System.EventArgs e)
        {
            if (displayString.Length > 1)
            {
                displayString = displayString.Substring(0, displayString.Length - 1);
                displayValue = Convert.ToDecimal(displayString);
                txtDisplay.Text = displayValue.ToString();
            }
            else
            {
                displayString = "";
                displayValue = 0;
                txtDisplay.Text = displayValue.ToString();
            }

        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            calc.Clear();
            displayString = "";
            displayValue = 0;
            txtDisplay.Text = displayValue.ToString();
            newValue = true;
            decimalEntered = false;
        }

        // This method appends a decimal point to the displayString field if the
        // user has not already entered a decimal point.
        private void btnDecimal_Click(object sender, System.EventArgs e)
        {
            if (newValue)
            {
                displayString = "0";
                newValue = false;
            }
            if (!decimalEntered)
            {
                displayString += ".";
                displayValue = Convert.ToDecimal(displayString);
                txtDisplay.Text = displayValue.ToString();
                decimalEntered = true;
            }
        }

        private void btnSign_Click(object sender, System.EventArgs e)
        {
            displayValue = -displayValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            calc.Add(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            calc.Subtract(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            calc.Multiply(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            calc.Divide(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnSqrt_Click(object sender, System.EventArgs e)
        {
            calc.SquareRoot(displayValue);
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();
        }

        private void btnReciprocal_Click(object sender, System.EventArgs e)
        {
            try
            {
                calc.Reciprocal(displayValue);
                displayValue = calc.CurrentValue;
                txtDisplay.Text = displayValue.ToString();
            }
            catch (DivideByZeroException)
            {
                displayValue = 0;
                txtDisplay.Text = "Cannot divide by zero.";
                newValue = true;
                decimalEntered = false;
            }
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (newValue)
                    calc.Equals();
                else
                    calc.Equals(displayValue);
                displayValue = calc.CurrentValue;
                txtDisplay.Text = displayValue.ToString();
                newValue = true;
                decimalEntered = false;
            }
            catch (DivideByZeroException)
            {
                displayValue = 0;
                txtDisplay.Text = "Cannot divide by zero.";
                newValue = true;
                decimalEntered = false;
            }
        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            calc.Divide(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();

        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            calc.Multiply(displayValue);
            newValue = true;
            decimalEntered = false;
            displayValue = calc.CurrentValue;
            txtDisplay.Text = displayValue.ToString();

        }
    }
}