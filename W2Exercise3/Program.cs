using System;

namespace W2Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmi;
            Console.WriteLine("Enter Weight:");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = double.Parse(Console.ReadLine());
            bmi = weight / Math.Pow(height, 2.0);
            Console.WriteLine("Your BMI is"+bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Under Weight");

            }
            else if ((bmi >= 18.5) && (bmi <= 24.99))
            {
                Console.WriteLine("Normal");

            }
            else if (bmi <= 25)
            {
                Console.WriteLine("Over Weight");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}
