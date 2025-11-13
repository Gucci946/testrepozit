namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");

            //loeme kasutaja sisendit ja see peab olema float andmetüüp
            float firstNumber = float.Parse(Console.ReadLine());
            //konsool kirjutab, et sisesta teine number
            //loeme kasutaja sisendit ja see peab olema float andmetüüp
            //mõlemal juhul tuleb float ära parsida
            Console.WriteLine("Sisesta teine number");
            float secondNumber = float.Parse(Console.ReadLine());

            //konsol kirjutab, et vali teha: +, -, *, /
            Console.WriteLine(" Vali teha: +, -, *, /");

            //kasutate switch, et teha valik kasutaja sisendi põhjal

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Tulemus: {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"Tulemus: {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"Tulemus: {firstNumber * secondNumber}");
                    break;
                case "/":
                    if (secondNumber != 0)
                        Console.WriteLine($"Tulemus: {firstNumber / secondNumber}");
                    else
                        Console.WriteLine("Viga: nulliga ei saa jagada!");
                    break;
                default:
                    Console.WriteLine("Tundmatu tehe!");
                    break;
            }

            Console.WriteLine("Vajuta suvalist klahvi, et väljuda...");
            Console.ReadKey();

        }
    }
}
