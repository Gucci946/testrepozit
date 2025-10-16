
namespace SwitchWithThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teie töö on teha switch rakendus ,
            //kus on kolm case (1, 2, 3).
            //Iga case puhul teeb erinev arv beep-e

            Console.WriteLine("Enter a number (1, 2, or 3):");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Beeping once");
                    Console.Beep();
                    break;
                case "2":
                    Console.WriteLine("Beeping twice");
                    Console.Beep();
                    Console.Beep();
                    break;
                case "3":
                    Console.WriteLine("Beeping three times");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                    break;
            }
        }
    }
}
