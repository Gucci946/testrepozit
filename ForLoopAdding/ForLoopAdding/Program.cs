namespace ForLoopAdding
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Täisarvude kokku liitmine kuni kümneni");
            Console.WriteLine("======================================\n");

            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Summa on: " + sum);
            }

            Console.WriteLine("\nPress any key to close this window . . .");
            Console.ReadKey();
        }
    }
}
