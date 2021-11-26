using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage;
            double principal, interestRate, monthlyPayment;
            int term, period;
            // Use .WriteLine to greet the user
            Console.WriteLine("Welcome to the Mortgage Calculator App");

            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)
            Console.WriteLine("Enter principal:");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter interest rate:");
            interestRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter term:");
            term = Int64.Parse(Console.ReadLine());

            Console.WriteLine("Enter period:");
            period = Int64.Parse(Console.ReadLine());

            // Create a new Mortgage with the given attributes;
            mortgage = new Mortgage(principle, interest, term, period);
            // Use the Mortgage functions to calculate the monthly payment
            monthlyPayment = mortgage.Calculate();
            // Use WriteLine to output the monthly payment
            Console.WriteLine($"Monthly Payment: {monthlyPayment}");

        }
    }
}
