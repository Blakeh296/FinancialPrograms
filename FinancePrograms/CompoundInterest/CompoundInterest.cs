using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    class CompoundInterest
    {
        public static double CpInterestConversion (double P, double n, double INTEREST_RATE, double r, double c)
        {
            double R = 1;

            if (c == 1)
            {
                      R = (r * 12);
            }
            else if (c == 2)
            {
                     R = (r * 6);
            }
            else if (c == 4)
            {
                     R = (r * 3);
            }
            else if (c == 12)
            {
                       R = r;
            }

            // R is how frequently to deposit per year
            
            
            // interest rate divided by how often to compound
            double ic = INTEREST_RATE / c;
            // Body of the left side of the equation
            double body = 1 + ic;
            // exponent for the left side of the equation
            double exponent = n * c;
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

            return FV;
        }
    }
}
