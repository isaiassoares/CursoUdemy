using System;
using System.Globalization;

namespace s3.Exercicio_de_fixacao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
            //Entre com seu nome completo:
            //  Alex Green
            //Quantos quartos tem na sua casa?
            //  3
            //Entre com o preço de um produto:
            //  500.50
            //Entre seu último nome, idade e altura(mesma linha):
            //  Green 21 1.73
            //-------------------------------------------------------------------------------

            //SAÍDA ESPERADA(NÚMEROS REAIS COM DUAS CASAS DECIMAIS):
            //Alex Green
            //  3
            //  500.50
            //  Green
            //  21
            //  1.73


            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
