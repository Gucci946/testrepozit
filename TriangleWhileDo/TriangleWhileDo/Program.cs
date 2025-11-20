using System;

class Program
{
    static void Main()
    {
        Console.Write("Kolmnurk:");
        int n = int.Parse(Console.ReadLine());

        int i = 1;                

        while (i <= n)
        {
            int j = 1;
            do
            {
                Console.Write("* ");
                j++;
            }
            while (j <= i);

            Console.WriteLine();
            i++;
        }
    }
}

