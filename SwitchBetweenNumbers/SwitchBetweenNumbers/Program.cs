namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimese kondtulemuse puhul on number vahemikus
            //0 kuni 100
            //Teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasutada switchi
            Console.Write("Sisesta number:");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Number on vahemikus 0 kuni 100.");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Number on vahemikus 101 kuni 200.");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Number on vahemikus 201 kuni 300.");
                    break;

                default:
                    Console.WriteLine("Number ei ole vahemikus 0 kuni 300.");
                    break;
            }

            Console.ReadLine();
        }
    }
}

