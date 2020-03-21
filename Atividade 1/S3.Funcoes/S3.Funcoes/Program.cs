using System;

namespace S3.Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler três números inteiros e mostrar na tela o maior deles.
            //Exemplo:
            //  Digite três números:
            //  5
            //  8
            //  3
            //  Maior = 8

            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
