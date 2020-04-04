using System;
using System.Globalization;

namespace S4.CAP45_Exercicios_propostos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R;

            R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = {0}", R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = {0}", R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}", R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
