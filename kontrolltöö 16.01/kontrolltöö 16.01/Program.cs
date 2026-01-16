using System.ComponentModel.Design;

namespace kontrolltöö_16._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Püramid");
            Console.WriteLine("2. Rüstküliku");
            Console.WriteLine("3. Ruutvõrandi");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Püramid();
            }
            else if (choice == "2")
            {
                Rüstküliku();
            }
            else if (choice == "3")
            {
                Ruutvõrrandi();
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        static void Püramid()
        {
            int i, j, n;

            Console.Write("Loo püramid tärnidest: \n");
            Console.Write("----------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta püramidi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void Rüstküliku()
        {
            Console.WriteLine("Ristkülik");

            //teha for loopiga ristkülik
            Console.WriteLine("Sisesta pikkus");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta laius");
            int col = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //teha kalkulatsioon, kus arvutatakse pindala ja ümbermõõt
            int S = row * col;
            int P = 2 * (row + col);
            Console.WriteLine("Pindala on " + S);
            Console.WriteLine("Ümbermõõt on " + P);
        }

        static void Ruutvõrrandi()
        {
            Console.WriteLine("Ruutvõrrand");

            //kasutaja peab saama sisestada väärtuseid a, b ja c

            Console.Write("Sisesta a väärtus ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta b väärtus ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta c väärtus ");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;

            Console.WriteLine($"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}, " +
                $"x2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
        }
    }
}






