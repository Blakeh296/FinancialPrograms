using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancePrograms
{
    class MorgageCalulation
    {
        public static double MorgageMonthly (double Principle, double downpayment, double INTEREST_RATE, double loanLenghthInMonths)
        {
            double monthlyPayment;
            double onePlusRTimesN;
            // Numerator for formula
            double numer;
            // Denominator for fomula
            double denom;


            onePlusRTimesN = Math.Pow((1 + INTEREST_RATE), loanLenghthInMonths);

            numer = INTEREST_RATE * onePlusRTimesN;

            denom = onePlusRTimesN - 1;

            monthlyPayment = Principle * (numer / denom);

            return monthlyPayment;
        }
    }
}
