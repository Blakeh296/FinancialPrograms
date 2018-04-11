using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Basic variables
            double P;
            double r;
            double n;
            double INTEREST_RATE;
            double monthlyContribution;
            double totalInterest;
            double finalAmount;
            double R;
            try
            {
                P = double.Parse(tbInitialDeposit.Text);

                n = double.Parse(tbNumberofYears.Text);

                INTEREST_RATE = double.Parse(tbInterestRate.Text) / 100;

                r = double.Parse(tbmonthlyContribution.Text);

                monthlyContribution = ((double.Parse(tbmonthlyContribution.Text) * 12) * n);
                double monthlyInterest = monthlyContribution * INTEREST_RATE;

                double monthywithInterest = monthlyInterest + monthlyContribution;
                if (cbTimesPerYear.Text == "Annual") // ANNUAL IS THE ONLY WORKING ONE 
                {
                    lblErrorHandler.Visible = false;

                    R = (r * 12);

                    double c = 1;

                    double ic = INTEREST_RATE / c;
                    double body = 1 + ic;
                   
                    double exponent = n * c;

                    double Body1 = P * Math.Pow(body, exponent);

                    double body2first = Math.Pow(body, exponent);
                    double subtract = body2first - 1;
                    double body2 = R * subtract;
                    double rightfinal = body2 / ic;
                    double FV = Body1 + rightfinal;

                    finalAmount = FV + r * n;

                    totalInterest = finalAmount - (P + monthlyContribution);

                    listBox1.Items.Add("< Calculation for " + n.ToString() + " years >");
                    listBox1.Items.Add("Predicted Account Value  :");
                    listBox1.Items.Add(finalAmount.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Interest earned  :");
                    listBox1.Items.Add(totalInterest.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Deposited Money :");
                    listBox1.Items.Add(monthlyContribution.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");

                }
                else if (cbTimesPerYear.Text == "Bi - Annual")
                {

                    lblErrorHandler.Visible = false;


                    double timesPerYear = 2;


                    double body = 1 + (INTEREST_RATE / timesPerYear);

                    double exponent = timesPerYear * n;

                    double principle = P * Math.Pow(body, exponent);

                    finalAmount = principle + r * n;

                    totalInterest = finalAmount - (P + monthlyContribution);

                    listBox1.Items.Add("< Calculation for " + n.ToString() + " years >");
                    listBox1.Items.Add("Predicted Account Value  :");
                    listBox1.Items.Add(finalAmount.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Interest earned  :");
                    listBox1.Items.Add(totalInterest.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Deposited Money :");
                    listBox1.Items.Add(monthlyContribution.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                }
                else if (cbTimesPerYear.Text == "Quarterly")
                {

                    lblErrorHandler.Visible = false;

                    double timesPerYear = 4;

                    double body = 1 + (INTEREST_RATE / timesPerYear);

                    double exponent = timesPerYear * n;

                    double principle = P * Math.Pow(body, exponent);

                    finalAmount = principle + r * n;

                    totalInterest = finalAmount - (P + monthlyContribution);

                    listBox1.Items.Add("< Calculation for " + n.ToString() + " years >");
                    listBox1.Items.Add("Predicted Account Value  :");
                    listBox1.Items.Add(finalAmount.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Interest earned  :");
                    listBox1.Items.Add(totalInterest.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Deposited Money :");
                    listBox1.Items.Add(monthlyContribution.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                }
                else if (cbTimesPerYear.Text == "Monthly")
                {
                    lblErrorHandler.Visible = false ;
                    

                    double  timesPerYear = 12;

                    double body = 1 + (INTEREST_RATE / timesPerYear);

                    double exponent = timesPerYear * n;

                    double principle = P * Math.Pow(body, exponent);

                    finalAmount = principle + r * n;

                    totalInterest = finalAmount - (P + monthlyContribution);

                    listBox1.Items.Add("< Calculation for " + n.ToString() + " years >");
                    listBox1.Items.Add("Predicted Account Value  :");
                    listBox1.Items.Add(finalAmount.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Interest earned  :");
                    listBox1.Items.Add(totalInterest.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Deposited Money :");
                    listBox1.Items.Add(monthlyContribution.ToString("#.##") + " $");
                    listBox1.Items.Add(" ");

                }


                
            }
           catch (Exception ex)
            {
                lblErrorHandler.Visible = true;
                lblErrorHandler.BackColor = System.Drawing.Color.Black;
                lblErrorHandler.ForeColor = System.Drawing.Color.Red;
                lblErrorHandler.Text = "* ERROR *";
            }
       
                

                

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblErrorHandler.Visible = false;
            tbInitialDeposit.Text = " ";
            tbInterestRate.Text = " ";
            tbmonthlyContribution.Text = " ";
            tbNumberofYears.Text = " ";
            listBox1.Items.Clear();
            cbTimesPerYear.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
