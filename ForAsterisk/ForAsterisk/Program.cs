namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asterisk e *");

            int nr = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nr; i++)
            {
                Console.Write("*");
            }
        }
    }
}


