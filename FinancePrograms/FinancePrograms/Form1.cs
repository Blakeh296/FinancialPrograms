using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancePrograms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal OriginalAmount;
            decimal downpayment;
            decimal AMOUNT_LOANED;
            decimal INTEREST_RATE;
            decimal LoanLength;
            decimal TOTAL_PRINCIPLE;
            decimal TOTAL_INTEREST;
            decimal MonthlyPayment;

            // Set Ask == to the first textbox
            OriginalAmount = decimal.Parse(lblLoanAsk.Text);
            // Set downpayment == to the second textbox
            downpayment = decimal.Parse(lblDownPayment.Text);
            // Loan Lenght == textbox 3
            LoanLength = decimal.Parse(lblLoanLength.Text);
            if (LoanLength >= 12)
            {
                LoanLength = LoanLength / 12;
            }
            // INTEREST_RATE == textbox 4 
            INTEREST_RATE = decimal.Parse(textBox4.Text) / 100;

            // set AMOUNT_LOANED == to the amount of money the person wants - down payment
            AMOUNT_LOANED = OriginalAmount - downpayment;

            TOTAL_PRINCIPLE = (OriginalAmount * LoanLength) *INTEREST_RATE;

            MonthlyPayment = TOTAL_PRINCIPLE / LoanLength;

            TOTAL_INTEREST = TOTAL_PRINCIPLE - AMOUNT_LOANED;

            Outputlbl_Principle.Text = TOTAL_PRINCIPLE.ToString("c");

            Outputlbl_INTEREST.Text = TOTAL_INTEREST.ToString("c");

            label5.Text = MonthlyPayment.ToString("c");
        }
    }
}
