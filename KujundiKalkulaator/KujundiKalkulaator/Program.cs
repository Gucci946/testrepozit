namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kujundi Kalkulator");

            // Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            // Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt.

            int roundRadius = 3;
            int squareSide = roundRadius * 2;

            int squareArea = squareSide * squareSide;
            int squarePerimeter = 4 * squareSide;

            Console.WriteLine($"Ruudu külg: {squareSide}");
            Console.WriteLine($"Ruudu pindala: {squareArea}");
            Console.WriteLine($"Ruudu ümbermõõt: {squarePerimeter}");

            // Leia ja väljasta ekraanile ringi pindala ja ümbermõõt

            double circleArea = Math.PI * roundRadius * roundRadius;
            double circleCircumference = 2 * Math.PI * roundRadius;

            Console.WriteLine($"Ringi pindala: {circleArea:F2}");
            Console.WriteLine($"Ringi ümbermõõt: {circleCircumference:F2}");
        }
    }
}
 
