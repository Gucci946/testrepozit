using System;

namespace FoorLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            Console.WriteLine("Loo püramid tärnidest:\n");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Sisesta püramiidi suurus:");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPüramiid:\n");

            for (i = 1; i <= n; i++)
            {               
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
