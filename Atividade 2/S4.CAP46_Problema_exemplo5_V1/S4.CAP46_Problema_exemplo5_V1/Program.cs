using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: {0}",circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: {0}",Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}