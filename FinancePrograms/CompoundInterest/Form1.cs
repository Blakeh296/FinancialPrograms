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
            // P is the principle
            double P;
            // r is the amount of money the person wants to deposit
            double monthlyContribution;
            // n is the total number of years
            double numberofYears;
            // Interest rate picked by the user
            double INTEREST_RATE;
            // totalContribution is how much money you would have deposited over time without interest
            double totalContribution;
            // Total money earned from interest alone
            double totalInterest;
            // we us little r to determine compound frequency with big r
            double R;
            double c = 0;
            
            try
            {
                
                
                P = double.Parse(tbInitialDeposit.Text);
                // N is total years
                numberofYears = double.Parse(tbNumberofYears.Text);
                // Get the interest rate / 100
                INTEREST_RATE = double.Parse(tbInterestRate.Text) / 100;
                // r is how much you want to deposit per month
                monthlyContribution = double.Parse(tbmonthlyContribution.Text);
                
                
                
                if (cbTimesPerYear.Text == "Annual") 
                {
                    lblErrorHandler.Visible = true;

                   
                    // Number of times to compound
                     c = 1;

                    
                }
                else if (cbTimesPerYear.Text == "Bi - Annual")
                {

                    lblErrorHandler.Visible = true;

                    // Number of times to compound
                     c = 2;

                    
                }
                else if (cbTimesPerYear.Text == "Quarterly")
                {

                    lblErrorHandler.Visible = true;
                    // number of times to compound
                     c = 4;

                    
                }
                else if (cbTimesPerYear.Text == "Monthly")
                {
                    lblErrorHandler.Visible = true ;


                    // number of times to compound
                     c = 12;

                    
                }

                // THE VARIABLE BELOW IS USED FOR MY OUTPUT, I KEPT THE CODE FOR MY OTHER OUTPUTS
                    double conversion = CompoundInterest.CpInterestConversion(P, numberofYears, INTEREST_RATE, monthlyContribution, c);

                    // R is how frequently to deposit per year
                    R = (monthlyContribution * 6);
                    // totalContribution is how much money you would have deposited without interest
                    totalContribution = (R * numberofYears);
                    // interest rate divided by how often to compound
                    double ic = INTEREST_RATE / c;

                    // Body of the left side of the equation
                    double body = 1 + ic;
                    // exponent for the left side of the equation
                    double exponent = numberofYears * c;
                    // using math.pow to execute the math in the proper order and to save all that in one variable
                    double Body1 = P * Math.Pow(body, exponent);
                    // we reuse the math.pow to save the same results again seperate from the first
                    double body2first = Math.Pow(body, exponent);
                    // minus one after the exponent is calculated
                    double subtract = body2first - 1;
                    // multiply that by the yearly deposit 
                    double body2 = R * subtract;
                    // put the right half of the equation together, and divide by the demoninator
                    double rightfinal = body2 / ic;
                    // add the left and right half of the formula together
                    double FV = Body1 + rightfinal;



                    totalInterest = FV - (P + totalContribution);

                    listBox1.Items.Add("< Calculations for " + numberofYears.ToString() + " years > " + cbTimesPerYear.Text);
                    listBox1.Items.Add("Predicted Account Value  :");
                    // CONVERSION CLASS IS OUTPUT HERE
                    listBox1.Items.Add(conversion.ToString("c"));
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Interest earned  :");
                    listBox1.Items.Add(totalInterest.ToString("c"));
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Total Deposited Money :");
                    listBox1.Items.Add(totalContribution.ToString("c"));
                    listBox1.Items.Add(" ");
                    listBox1.Items.Add("Account Math :");
                    listBox1.Items.Add(P.ToString("c") + " + " + totalContribution.ToString("c") + " + " + totalInterest.ToString("c"));
                    // AND HERE
                    listBox1.Items.Add(" = " + conversion.ToString("c"));
                    listBox1.Items.Add(" ");

                    // display text
                    lblErrorHandler.Text = " ! Success !";
                    // make  sure the text isnt red
                    lblErrorHandler.ForeColor = System.Drawing.Color.Black;
                    // change title header color
                    label6.BackColor = System.Drawing.Color.LightGreen;
                
            }
           catch (Exception ex)
            {
                // Make sure the ERROR Handler is turned on
                lblErrorHandler.Visible = true;
                lblErrorHandler.ForeColor = System.Drawing.Color.Red;
                label6.BackColor = System.Drawing.Color.Red;
                lblErrorHandler.Text = "* ERROR *";

                // Suggestions for why the code stopped working
                MessageBox.Show(ex.Message);
                listBox1.Items.Add("< ERROR TIPS >");
                listBox1.Items.Add(" ");
                listBox1.Items.Add("1. NUMBERS ONLY");
                listBox1.Items.Add(" ");
                listBox1.Items.Add("2. NONE of the fields can be empty");
                listBox1.Items.Add(" ");
                listBox1.Items.Add("3. Ensure a Compound frequency");
                listBox1.Items.Add(" is selected from the drop down list");
                
                
               
            }
       
                

                

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove the error handler from view
            lblErrorHandler.Visible = false;
            // Reset back to original color
            label6.BackColor = System.Drawing.Color.LightBlue;
            // Clear all text boxes
            tbInitialDeposit.Text = " ";
            tbInterestRate.Text = " ";
            tbmonthlyContribution.Text = " ";
            tbNumberofYears.Text = " ";
            cbTimesPerYear.Text = " ";
            // Clear all list box items
            listBox1.Items.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Closes this form
            this.Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // set the back color to the title header
            label6.BackColor = System.Drawing.Color.LightBlue;
        }

        
    }
}
