namespace SulgudeKasutamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sulgude kasutamine");
            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 =?");

            double calulation1 = 3 + 8 / (4 - 2) * 4;
            double calulation2 = 3 + 8 / 4 - 2 * 4;
            double calulation3 = (3 + 8) / (4 - 2) * 4;
            double calculation4 = 3 + 8 / ((4 - 2) * 4);

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calulation1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + calulation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calulation3);
            Console.WriteLine("3 + 8 / ((4 - 2) * 4) = " + calculation4);

        }
    }
}
