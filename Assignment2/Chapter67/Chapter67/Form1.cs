using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter67
{
    public partial class Form1 : Form
    {
        const int MONTHS_IN_A_YEAR = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var monthlyInvestment = Convert.ToDecimal(txtFieldInvestment.Text);
            var interestRate = Convert.ToDecimal(txtInterestRate.Text);
            var years = Convert.ToInt32(txtYears.Text);

            var months = years * MONTHS_IN_A_YEAR;
            var monthlyInterestRate = interestRate / MONTHS_IN_A_YEAR / 100;

            var futureValue = calculateFutureValue(monthlyInvestment, months, monthlyInterestRate);

            txtFutureValue.Text = futureValue.ToString("c");
            txtFieldInvestment.Focus();
        }

        private decimal calculateFutureValue(decimal monthlyInvestment, int months, decimal monthlyInterestRate)
        {
            var futureValue = 0m;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                                    * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
