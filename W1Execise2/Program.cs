using System;

namespace W1Execise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number\t|square\t|cube");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+"\t"+(i*i)+"\t"+(i*i*i));
                Console.ReadLine();
            }
        }
    }
}
