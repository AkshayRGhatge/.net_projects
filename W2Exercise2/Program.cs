using System;

namespace W2Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Monthly Investment");
            double monthlyInvest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter yearly Interest Rate");
            double yearlyInterest = double.Parse(Console.ReadLine());

            Console.Write("Number of years");
            int numberOfYears = int.Parse(Console.ReadLine());

            double monthlyInterest = yearlyInterest / 12 / 100;
            int numberOfmonths = numberOfYears * 12;
            double futureValue = 0.0;

            for (int i = 0; i < numberOfmonths; i++)
            {
                futureValue = (futureValue + monthlyInvest) * (1 + monthlyInterest);
            }
            Console.WriteLine("\n Future Value:"+futureValue.ToString("C"));
            Console.ReadKey();
        }
    }
}
