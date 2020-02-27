using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 110;
            int k = 11;
            //while (n != 0)
            //{


            for (int i = 1; n != 0; i++)
            {
                if ((i % 3 == 0) & (i % 5 == 0))
                {
                    Console.Write("US" + " ");
                }
                else if ((i % 5 == 0) & (i % 7 == 0))
                {
                    Console.Write("SF" + " ");
                }
                else if ((i % 3 == 0) & (i % 7 == 0))
                {
                    Console.Write("UF" + " ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("U" + " ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("S" + " ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("F" + " ");
                }
                else
                {

                    Console.Write(i + " ");
                }
                n--;
                
                if (n % k == 0)
                    Console.WriteLine("\n");

            }
        }
    }
}
