using System;

namespace s3.Ex_coversao_implicita_e_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1

            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            //Exemplo 2
            double c;
            int d;
            c = 5.1;
            d = (int)c;
            Console.WriteLine(d);

            //Exemplo 3
            int e = 5;
            int f = 2;
            double resultado = (double)e / f;
            Console.WriteLine(resultado);
        }
    }
}
