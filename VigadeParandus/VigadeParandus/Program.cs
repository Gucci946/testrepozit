namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peab kasutama switchi");
            Console.WriteLine("1. Tagurpidi püramiid");
            Console.WriteLine("2. Ristikülik");

            //teha switch, kus on kolm case valikut
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //meetod tuleb välja kutsuda
                    UpsidePyramiid();
                    break;

                case "2":
                    Rectangle();
                    break;

                case "3":
                    Püramiid();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;

            }
        }
        static void UpsidePyramiid()
        {
            Console.WriteLine("Sisesta kõrgus:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void Rectangle()
        {
            Console.WriteLine("Sisesta pikkus:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta laius:");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Püramiid()
        {
            Console.WriteLine("Sisesta kõrgus:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
}


