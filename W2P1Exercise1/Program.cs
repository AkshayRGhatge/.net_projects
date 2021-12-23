using System;

namespace W2P1Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type customer C or R");
            char custType = Console.ReadLine().ToUpper()[0];

            Console.WriteLine("Enter subtotal");
            double subTotal = double.Parse(Console.ReadLine());

            double discountPercent = 0.0;

            switch (custType)
            {
                case 'R':
                    if (subTotal >= 250)
                        discountPercent = 0.25;
                    else if (subTotal >= 100 && subTotal < 250)
                        discountPercent = 0.1;
                    break;

                case 'C':
                    if (subTotal >= 250)
                        discountPercent = 0.3;
                    else
                        discountPercent = 0.2;

                    break;
                default:
                    Console.WriteLine("Invalid customer type");
                    break;
            }

                    double discountAmount = subTotal * discountPercent;
                    double total = subTotal - discountAmount;


                    Console.WriteLine("Discount Percent" + discountPercent.ToString("P1"));
                    Console.WriteLine("Discount Amount" + discountAmount.ToString("C"));
                    Console.WriteLine("Total" + total.ToString("C"));
                    Console.ReadKey();


            }
        }
    }

