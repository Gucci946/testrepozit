using System;

namespace SwitchWeekDay
{
    internal class Program
    {
        static void Main(string[] args)
            //tuleb kasutada switchi
            //kui on esmaspäev, siis konsoolis kuvatakse
            //"Esmspäev on tööpäev"
            //peate kasutama DayOfWeek enumertrsiooni
        {
            // Võtame tänase päeva süsteemist
            DayOfWeek today = DateTime.Now.DayOfWeek;

            // Kuvame tänase päeva nime
            Console.WriteLine($"Täna on {today}.");

            // Kasutame switch-lause abil kontrolli
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Esmaspäev on tööpäev.");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Teisipäev on tööpäev.");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Kolmapäev on tööpäev.");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Neljapäev on tööpäev.");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Reede on tööpäev.");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Laupäev on nädalavahetus!");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Pühapäev on nädalavahetus!");
                    break;

                default:
                    Console.WriteLine("Midagi läks valesti!");
                    break;
            }

            Console.ReadLine(); // et aken kohe ei sulguks
        }
    }
}
