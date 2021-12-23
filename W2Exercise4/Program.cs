using System;

namespace W2Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N\t10N\t100N\t1000N");

            for (int i = 0; i < 5; i++)
            {
                int ten = 10 * i;
                int hundred = 100 * i;
                int thousand = 1000 * i;
                Console.WriteLine(i+"\t"+ten+"\t"+hundred+"\t"+thousand);
            }
            Console.ReadKey();
        }
    }
}
