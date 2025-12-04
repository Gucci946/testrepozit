namespace ForLoopEndLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For lopp endless");

            //kasutame for loopi
            ushort i = 0;

            // kui on 10 rida konsoolis, siis lõpetab ära
            //VIHJE kasutage break-i

            for (; ; )

            {
                Console.WriteLine("Rida: " + (i + 1));
                i++;

                if (i == 10)
                {
                    break;
                }
            }

            Console.WriteLine("Tsükkel lõpetatud!");
        }
    }
}
