namespace MaaKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maa kalkulator");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            // Mündi diameeter (mm)
            double muntDiameeterMm = 25.75;

            double maaRaadiusKm = 6371;
            double maaRaadiusMm = maaRaadiusKm * 1_000_000; // 1 km = 1 000 000 mm

            double ymbermootMm = 2 * Math.PI * maaRaadiusMm;

            double muntideArv = ymbermootMm / muntDiameeterMm;

            Console.WriteLine($"Maa ümbermõõt: {ymbermootMm:N0} mm");
            Console.WriteLine($"Münte ümber Maa: {muntideArv:N0}");
        }
    }
}
