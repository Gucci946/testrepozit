using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("kasuta formaatI: s--a. Kus - tähistab tudmatut tähte");

            string choise = Console.ReadLine();

            WordFinder(choise);
        }

        private static void WordFinder(string word)
        {
            Regex regularExp = new Regex(
                @"\b" + word.Replace("-", "."),
                RegexOptions.Compiled | RegexOptions.IgnoreCase
            );

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Downloads/lemmad.txt", Encoding.Default))
                {
                    int lineNumber = 0;

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();

                        if (line.Length == word.Length)
                        {
                            MatchCollection mathCollection = regularExp.Matches(line);

                            if (mathCollection.Count > 0)
                            {
                                lineNumber++;
                                Console.WriteLine(lineNumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ei ole olemas sellise pikkusega sõnu");
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
