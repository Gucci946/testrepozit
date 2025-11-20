namespace whileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int i = 1;

            do
            {
                Console.WriteLine(i);
                //i++ tähendab, et sama mis i = i + 1
                i++;
            } while (i <= 10);
            //kui tuli nr 11, siis tingimus ei kehti enam ja tsükkel lõpeb 
        }
    }
}
