namespace FailWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:/Users/opilane/Desktop/UusTekstidokument.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
    }
}
