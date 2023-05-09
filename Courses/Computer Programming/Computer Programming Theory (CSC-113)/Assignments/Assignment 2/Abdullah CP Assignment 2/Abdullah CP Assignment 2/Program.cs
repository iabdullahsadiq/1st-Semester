using System;

namespace Abdullah_CP_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double loan, year;

            Console.WriteLine("Please enter the Amount you want for Loan:");
            loan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("For how many years you want the Amount:");
            year = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            double ipFee = loan * 0.03;
            double insurance = loan * 0.02;
            double markUp = (loan * 0.18) * year;
            double payableAmount = loan + insurance + markUp;
            double months = year * 12;
            double monthlyInstallment = payableAmount / months;

            Console.WriteLine("\nAmount Taken: {0} ", loan);
            Console.WriteLine("Monthly Installment: {0}", monthlyInstallment);
            Console.WriteLine("Initial Processing Fee: {0} (To be paid once at the time of Approval of Loan).",ipFee);
            Console.WriteLine("Insurance Fee: {0} (2% of Loan)", insurance);
            Console.WriteLine("Total ammount to pay after {0} year: {5} Rs.", payableAmount);
        }
    }
}
