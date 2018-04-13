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
            double Principle;
            double downpayment;
            double INTEREST_RATE;
            double loanLength = 0;
            double monthlyPayment;
            double totalInterest;
            double totalPayment;
            DateTime startDate;

            try
            {
                // Set downpayment == to the second textbox
                downpayment = double.Parse(tbDownPayment.Text);

                // Set Ask == to the first textbox
                Principle = double.Parse(tbLoanAsk.Text) - downpayment;
                // Loan Lenght == textbox 3

                if (comboBox1.Text == "Years")

                { 
                    loanLength = double.Parse(comboBox2.Text.ToString()) * 12; }

                else if (comboBox1.Text == "Months")

                { 
                    loanLength = double.Parse(comboBox2.Text.ToString());
                }
                

                // INTEREST_RATE == textbox 4 
                INTEREST_RATE = double.Parse(tbInterest.Text) / 100 / 12;
                // Monthly calculation
                monthlyPayment = MorgageCalulation.MorgageMonthly(Principle, downpayment, INTEREST_RATE, loanLength);
                // Reset combo box, make sure it isnt blank
                comboBox1.Text = "Years";

                // total interest to display to the user
                totalInterest = ((monthlyPayment * loanLength) - (Principle + downpayment));

                totalPayment = (monthlyPayment * loanLength);

                startDate = DateTime.Parse(lblStartDate.Text);
                DateTime PayoffDate = startDate.AddMonths((int)loanLength);

                // Display variables to the user
                listBox1.Items.Add("Monthly Payment = " + monthlyPayment.ToString("c"));
                listBox1.Items.Add("Total Interest = " + totalInterest.ToString("c"));
                listBox1.Items.Add("Out of Pocket Expense = " + totalPayment.ToString("c"));
                listBox1.Items.Add("Pay off Date = " + PayoffDate.ToShortDateString());
                listBox1.Items.Add(" ");

                lblErrorHandler.ForeColor = System.Drawing.Color.Black;
                lblErrorHandler.Text = "! Success !";
                lblTitle.BackColor = System.Drawing.Color.LightGreen;
                
            }
            catch (Exception ex)
            {
                // If one of the wrong combo box options is picked, display specific error message
                if (comboBox2.Text == "Years" || comboBox2.Text == "Months")
                {
                    lblTitle.BackColor = System.Drawing.Color.Red;
                    lblErrorHandler.ForeColor = System.Drawing.Color.Red;
                    lblErrorHandler.Text = " You can not click 'Years' or 'Months' ";
                    
                }
                else
                {
                    lblTitle.BackColor = System.Drawing.Color.Red;
                    lblErrorHandler.ForeColor = System.Drawing.Color.Red;
                    lblErrorHandler.Text = " * ERROR * ";
                    // Display error
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbDownPayment.Text = " ";
            tbInterest.Text = " ";
            tbLoanAsk.Text = " ";
            listBox1.Items.Clear();
            comboBox2.Text = " ";
            lblTitle.BackColor = System.Drawing.Color.LightBlue;
            lblErrorHandler.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
