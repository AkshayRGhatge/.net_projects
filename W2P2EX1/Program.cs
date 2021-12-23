using Microsoft.VisualBasic.CompilerServices;
using System;

namespace W2P2EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 3;
            a = Refparam(ref a);
            Console.WriteLine("the value of {0} and {1} is",a,b);

            int x = 60;
            int y = 55; 
            double newX;
            double newY;
            if (NormalisePoint(x,y,out newX,out newY)==true)
            {
                Console.WriteLine("The value {0} and {1} is " , newX,newY);
            }

           


            Console.ReadKey();
        }
        private static bool NormalisePoint(int x, int y,out double xOut,out double yOut)
        {
            xOut = 0;
            yOut = 0;
            if((x<1) && (x>100))
            {
                return false;
            }
            if((y<1)&&(y>100))
            {
                return false;
            }
            if(x>y)
            {
                xOut = x / x;
                yOut = y / (double)x;
            }
            else
            {
                xOut = x / ( double)y;
                yOut = x / x;
            }
            return true;
        }










        private static int Refparam(ref int z)
        {
            z++;
            return z;
        }
    }
}
