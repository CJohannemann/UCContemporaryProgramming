using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapters67
{
    public partial class FutureValueApplication : Form
    {
        const int MONTHS_IN_A_YEAR = 12;
        public FutureValueApplication()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            ValidateInput();

            try
            {
                //grab variables
                var monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                var interestRate = Convert.ToDecimal(txtInterest.Text);
                var years = Convert.ToInt32(txtYears.Text);

                //Convert to months
                var months = years * MONTHS_IN_A_YEAR;
                var monthlyInterestRate = interestRate / MONTHS_IN_A_YEAR / 100;

                //calculate future value
                decimal futureValue;
                CalculateFutureValue(monthlyInvestment, months, monthlyInterestRate, out futureValue);

                //Display
                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();
            }
            catch (FormatException f)
            {
                MessageBox.Show("Type the right shhtuff!");
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Enter a smaller number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "error");
            }

            isPresent();
            isDecimal();
            isInt32();
            isWithinRange();



        }
        //CalculateFutureValue(monthlyInvestment, months, monthlyInterestRate, out futureValue);
        private void isWithinRange()
        {
            decimal d;
            if(decimal.TryParse(txtInterest.Text, out d))
            {
                if(d > 0 && d < 100)
                {

                }
                else
                {
                    MessageBox.Show("Please enter a valid percent", "Error");
                }
            }

        }

        private void isInt32()
        {
            int i;
            if (int.TryParse(txtYears.Text, out i))
            {

            }
            else
            {
                MessageBox.Show("Please enter an integer", "Error");
                txtYears.Focus();
            }
        }

        private void isDecimal()
        {
            decimal d;
            if (decimal.TryParse(txtInterest.Text, out d))
            {

            }
            else
            {
                MessageBox.Show("Please enter a decimal format", "Error");
                txtInterest.Focus();
            }
        }

        private void isPresent()
        {
            if (txtMonthlyInvestment.Text == null)
            {
                MessageBox.Show("Monthly Investment can't be empty", "Error");
                txtMonthlyInvestment.Focus();
            }
            else if (txtInterest.Text == null)
            {
                MessageBox.Show("Yearly Interest can't be empty", "Error");
                txtInterest.Focus();
            }
            else if (txtYears.Text == null)
            {
                MessageBox.Show("Yearly Interest can't be empty", "Error");
                txtYears.Focus();
            }

        }

        private void ValidateInput()
        {
            checkThatCheckBoxesHaveStuffInThem();
            CheckForValidDecimal();
        }

        private void checkThatCheckBoxesHaveStuffInThem()
        {
            if (txtMonthlyInvestment.Text == "")
            {
                MessageBox.Show("Need data", "entry error");
                txtMonthlyInvestment.Focus();
            }
        }

        private void CheckForValidDecimal()
        {
            decimal monthlyInvestment = 0m;
            if (!(Decimal.TryParse(txtMonthlyInvestment.Text, out monthlyInvestment)))
            {
                MessageBox.Show("Monthly Investment must be a numeric vale.", "Entry Error");
            }
        }

        private void CalculateFutureValue(decimal monthlyInvestment, int months, decimal monthlyInterestRate, out decimal futureValue)
        {
            futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                               * (1 + monthlyInterestRate);
            }
        }
    }
}
