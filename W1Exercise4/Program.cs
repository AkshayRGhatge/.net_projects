using System;

namespace W1Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndnum = rnd.Next(10);
            int userguess;
            do
            {
                Console.WriteLine("Guess the number between 1-10");
                 userguess = int.Parse(Console.ReadLine());
                if (userguess == rndnum)
                {
                    Console.WriteLine("Correct Answer");
                }
                else if (userguess < rndnum)
                {
                    Console.WriteLine("Too low");

                }
                else
                {
                    Console.WriteLine("Too high");
                }
            } while (userguess != rndnum);
        
        }
        }
        }

