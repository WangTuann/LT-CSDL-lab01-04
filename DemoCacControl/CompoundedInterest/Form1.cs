using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundedInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPricipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = 0.00,
           interestRate = 0.00,
           interestEarned = 0.00;
            double futureValue = 0.00,
                   ratePerPeriod = 0.00,
                   periods = 0;
            int compoundType = 0;

            // Retrieve the value of the principal
            principal = double.Parse(txtPrincipal.Text);

            // Retrieve the interest rate
            interestRate = double.Parse(txtInterestRate.Text) / 100;

            // Find out what radio button was clicked to apply the compound frequency
            if (rdoMonthly.Checked)
                compoundType = 12;
            else if (rdoQuarterly.Checked)
                compoundType = 4;
            else if (rdoSemiannually.Checked)
                compoundType = 2;
            else
                compoundType = 1;

            // Get the number of periods
            periods = double.Parse(txtPeriods.Text);

            // These values will make the calculation easier to read
            double i = interestRate / compoundType;
            double n = compoundType * periods;

            // Perform the necessary calculations
            ratePerPeriod = interestRate / periods;
            futureValue = principal * Math.Pow(1 + i, n);
            interestEarned = futureValue - principal;

            // Display the values in the appropriate text boxes
            txtInterestEarned.Text = interestEarned.ToString("C");
            txtFutureValue.Text = futureValue.ToString("C");
        }
    }
}
