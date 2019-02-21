using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double proteinPrice = 0;
        private double sideItemTotalCost = 0;
        private double drinkPrice;

        public Form1()
        {
            InitializeComponent();
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            textAreaReceipt.Text = String.Empty;
            textAreaReceipt.Text += "Protein : ";
            textAreaReceipt.Text += proteinPrice.ToString("c");
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "Extras :  ";
            textAreaReceipt.Text += sideItemTotalCost.ToString("c");
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "Drinks :  ";
            textAreaReceipt.Text += drinkPrice.ToString("c");
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "------------------------";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "Total:    ";
            textAreaReceipt.Text += calcTotal().ToString("c");
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
            textAreaReceipt.Text += "\r\n";
        }


        private double calcTotal()
        {
            double subTotal = 0;
            subTotal += proteinPrice;
            subTotal += sideItemTotalCost;
            return subTotal;
        }



        private void comboBoxProteinSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProteinType(proteinPrice);
        }

        private double getProteinType(double proteinPrice)
        {
            String type = comboBoxProteinSelector.Text;
            if (type.Contains("--Select--"))
            {
                MessageBox.Show("Select a Protein"); ;
            }
            else if (type.Contains("Chicken"))
            {
                this.proteinPrice = 6.25;
            }
            else if (type.Contains("Steak"))
            {
                this.proteinPrice = 6.70;
            }
            else if (type.Contains("Carnitas"))
            {
                this.proteinPrice = 6.70;
            }
            else if (type.Contains("Barbacoa"))
            {
                this.proteinPrice = 6.70;
            }
            else if (type.Contains("Vegetarian"))
            {
                this.proteinPrice = 6.25;
            }
            return this.proteinPrice;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            getExtraSideAmount(sideItemTotalCost);
        }

        private double getExtraSideAmount(double sideItemTotalCost)
        {

            if (chkBoxExtras.GetItemChecked(0))
            {
                
                this.sideItemTotalCost += 3.15;
                
            }
            else if (chkBoxExtras.GetItemChecked(1))
            {
                this.sideItemTotalCost += 1.75;
            }
            else if (chkBoxExtras.GetItemChecked(2))
            {
                this.sideItemTotalCost += 1.90;
            }
            else if (chkBoxExtras.GetItemChecked(3))
            {
                this.sideItemTotalCost += 1.25;
            }
            else
            {
                this.sideItemTotalCost = 0;
            }
            return this.sideItemTotalCost;
        }

        private double getDrinkOrder()
        {
            bool isBeerSelected = radBtnBeer.Checked;
            if (isBeerSelected)
            {
                drinkPrice = 4.75;
            }
            return drinkPrice;
            
        }
        private void radBtnBeer_CheckedChanged(object sender, EventArgs e)
        {
            getDrinkOrder();
        }

        private double radBtnH20_CheckedChanged(object sender, EventArgs e)
        {
            bool isH20Selected = radBtnH20.Checked;
            if (isH20Selected)
            {
                drinkPrice = 2.00;
            }
            return drinkPrice;
        }

        private double radBtnSoda_CheckedChanged(object sender, EventArgs e)
        {
            bool isSodaSelected = radBtnSoda.Checked;
            if (isSodaSelected)
            {
                drinkPrice = 1.75;
            }
            return drinkPrice;
        }


    }
}
