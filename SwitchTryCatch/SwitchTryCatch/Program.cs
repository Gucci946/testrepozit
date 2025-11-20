using System;

namespace SwitchTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch koos Switch-ga");
            Console.WriteLine("Sisesta number 1 või 2");

            try
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Sisestasid numbri 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid numbri 2");
                        break;

                    default:
                        Console.WriteLine("Vali ainult 1 või 2!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta kehtiv number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number on liiga suur või liiga väike.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tekkis ootamatu viga: {ex.Message}");
            }
        }
    }
}

