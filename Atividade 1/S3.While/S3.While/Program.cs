using System;
using System.Globalization;

namespace S3.While
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Digitar um número e mostrar sua raiz quadrada com três casas decimais, 
            ///depois repetir o procedimento. Quando o usuário digitar um número
            ///negativo(podendo inclusive ser na primeira vez), mostrar uma mensagem "Número negativo" e terminar o programa.
            ///
            ///Digite um número: 25
            /// 5.000
            //Digite outro número: 10
            ///3.162
            //Digite outro número: 9
            ///3.000
            //Digite outro número: -4
            ///Número negativo!
            ///

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");

        }
    }
}
