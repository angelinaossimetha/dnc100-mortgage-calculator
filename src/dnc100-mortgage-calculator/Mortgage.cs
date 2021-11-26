using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_mortgage_calculator
{
    public class Mortgage
    {
        public double principle; 
        public double interest;
        public int term; 
        public int period; 

        public Mortgage(double principle, double interest, int term, int period)
        {
            this.principle = principle; 
            this.interest =  interest;
            this.term = term;
            this.period = period; 
        }

        public double Calculate()
        {
            double monthlyInterestRate = this.MonthlyInterestRate(this.interest, this.period);
            int numberOfPayments = this.NumberOfPayments(this.term, this.period);
            double compoundedInterestRate = this.CompoundedInterestRate(monthlyInterestRate, numberOfPayments);
            double interestQuotient = this.InterestQuotient(monthlyInterestRate, compoundedInterestRate, numberOfPayments);
            double monthlyPayment = this.principle * interestQuotient;
            return System.Math.Round(monthlyPayment, 2);
        }

        public double MonthlyInterestRate(double interest, int period)
        {
            return (interest / 100) / period;
        }

        public int NumberOfPayments(int term, int period)
        {
            return term * period;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
           return Math.Pow((1 + monthlyInterestRate), numberOfPayments);
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {
            return (monthlyInterestRate * compoundedInterestRate) / ((Math.Pow((1 + monthlyInterestRate), numberOfPayments)) - 1);
        }
    }
}
