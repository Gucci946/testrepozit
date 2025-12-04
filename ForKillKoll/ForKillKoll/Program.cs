namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //VIHJE: for loop for loopi sees

            Console.Write("Sisesta ridade arv: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n);

            for (int rida = 0; rida < n; rida++)
            {
                Console.WriteLine($"See on rida nr {rida}");

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("kill-koll");
                }

                Console.WriteLine("killadi-koll");
            }

            Console.WriteLine("kill - koll");
        }
    }
}

        
    

