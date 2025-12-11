namespace FoorLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
            {
                Console.WriteLine("Tärnidest tehtud kolmnurke poolik püramiid:");
                Console.WriteLine("============================================");
                Console.Write("Sisesta ridade arv: ");

                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nVajuta suvalist klahvi, et sulgeda...");
                Console.ReadKey();
            }
            }

        }
    }
}
