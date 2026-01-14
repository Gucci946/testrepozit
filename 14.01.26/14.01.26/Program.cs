namespace _14._01._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod (1-4):");
            Console.WriteLine("1 - for loop (3 korda tekst)");
            Console.WriteLine("2 - while loop (3 korda tekst)");
            Console.WriteLine("3 - kahe arvu liitmine");
            Console.WriteLine("4 - vanuse küsimine");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ForMethod();
            }
            else if (choice == 2)
            {
                WhileMethod();
            }
            else if (choice == 3)
            {
                SumMethod();
            }
            else if (choice == 4)
            {
                AgeMethod();
            }
            else
            {
                Console.WriteLine("Vale valik!");
            }
        }

        static void ForMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("See tekst kordub for-loopiga");
            }
        }

        static void WhileMethod()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("See tekst kordub while-loopiga");
                i++;
            }
        }

        static void SumMethod()
        {
            Console.Write("Sisesta esimene arv: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("Summa: " + sum);
        }

        static void AgeMethod()
        {
            Console.Write("Sisesta oma vanus: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Sinu vanus on: " + age);
        }
    }
}