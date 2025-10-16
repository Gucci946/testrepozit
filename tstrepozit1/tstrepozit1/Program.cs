namespace tstrepozit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");

            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("Sisesta tähe a");
                    break;

                case "e":
                    Console.WriteLine("Sisesta tähe e");
                    break;

                case "i":
                    Console.WriteLine("Sisesta tähe i");
                    break;

                default:
                    Console.WriteLine("Ei ole vokaal");
                    break;
            }
        }
    }
}
