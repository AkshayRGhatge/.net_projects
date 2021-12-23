using System;

namespace W1Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random1, random2;
            char ch = 'y';
            while (ch == 'y')
            {
                random1 = rnd.Next(1, 10);
                random2 = rnd.Next(1, 10);
                int correctanswer = random1 + random2;
                int userans;
                do { 
                    Console.WriteLine("What is " + random1 + " + " + random2 + " ?");
                userans = int.Parse(Console.ReadLine());
                if (userans == correctanswer)
                {
                    Console.WriteLine("Correct answer");

                }
                else
                {
                    Console.WriteLine("Wrong answer");
                }
            } while (userans != correctanswer) ;
            Console.WriteLine("Another question press y/n");
                ch = Console.ReadLine()[0];
        }

        }
    }
}
