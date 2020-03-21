using System;
using System.Globalization;

namespace S3.CAP35_Exercicios_propostos_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESTRUTURA FOR

            ///Exercício 1:
            ///Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
            ///

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadKey();

            ///Exercício 2:
            ///Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            ///Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            ///essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            int dentro = 0, fora = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int t = 1; t <= N; t++)
            {
                Console.Write("Valor #{0}: ", t);
                int w = int.Parse(Console.ReadLine());
                if (w >= 10 && x <= 20)
                {
                    dentro = dentro + 1;
                }
                else fora = fora + 1;

            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);


            Console.ReadKey();

            ///Exercício 3:
            ///Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            ///de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes
            ///conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

            int intN = int.Parse(Console.ReadLine());

            for (int y = 0; y < intN; y++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();

            ///Exercício 4:
            ///Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            ///segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            int z = int.Parse(Console.ReadLine());

            for (int h = 0; h < z; h++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int f = int.Parse(line[0]);
                int g = int.Parse(line[1]);

                if (g == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)f / g;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            Console.ReadKey();


            ///Exercício 5:
            ///Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            ///Lembrando que, por definição, fatorial de 0 é 1.
            ///

            int k = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int j = 1; j <= k; j++)
            {
                fat = fat * j;
            }

            Console.WriteLine(fat);

            Console.ReadKey();

            ///Exercício 6:
            ///Ler um número inteiro N e calcular todos os seus divisores
            ///

            int nn = int.Parse(Console.ReadLine());

            for (int l = 1; l <= nn; l++)
            {
                if (nn % l == 0)
                {
                    Console.WriteLine(l);
                }
            }

            Console.ReadKey();


            ///Exercício 7:
            ///Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            ///começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
            ///

            int nInt = int.Parse(Console.ReadLine());

            for (int m = 1; m <= nInt; m++)
            {

                int primeiro = m;
                int segundo = m * m;
                int terceiro = m * m * m;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }

            Console.ReadKey();

        }
    }
}

