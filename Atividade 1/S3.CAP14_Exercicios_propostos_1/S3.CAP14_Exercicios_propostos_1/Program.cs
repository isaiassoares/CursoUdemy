using System;
using System.Globalization;

namespace S3.CAP24_Exercicios_propostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// ESTRUTURA SEQUENCIAL
            /// 



            //Exercicio 1:
            ///Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            ///mensagem explicativa, conforme exemplos.
            ///ENTRADA: 10 30
            ///SAÍDA: SOMA = 40
            ///

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("SOMA = {0}", soma);

            Console.ReadKey();

            //Exercicio 2:
            ///Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
            ///Fórmula da área: area = π.raio2
            ///Considere o valor de π = 3.14159
            ///
            /// 
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadKey();

            //Exercício 3:
            /// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            /// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            /// 

            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

            int diferenca = (a2 * b2) - (c2 * d2);
            Console.WriteLine("DIFERENÇA = {0}",diferenca);

            Console.ReadKey();

            //Exercício 4
            ///Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            /// hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
            /// 

            Console.WriteLine("Codigo funcionario:");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhadas:");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de hora:");
            double valorHH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valorHH * horasTrabalhadas;

            Console.WriteLine("NUMBER = {0}", numFuncionario);
            Console.WriteLine("U$ SALARY = {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

            //Exercício 5
            ///Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            ///código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            ///


            int cod1, num1, cod2, num2;
            double valor1, valor2, conta;

            Console.Write("Informe o código do primeiro produto:");
            cod1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de peças do primeiro produto:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor do primeiro produto:");
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.Write("Informe o código do segundo produto:");
            cod2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de peças do segundo produto:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor do segundo produto:");
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta = (num1 * valor1) + (num2 * valor2);

            Console.WriteLine(" ");
            Console.WriteLine("VALOR A PAGAR: R$ " + conta.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();


            ///Exercício 6:
            ///Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            ///a) a área do triângulo retângulo que tem A por base e C por altura.
            ///b) a área do círculo de raio C. (pi = 3.14159)
            ///c) a área do trapézio que tem A e B por bases e C por altura.
            ///d) a área do quadrado que tem lado B.
            ///e) a área do retângulo que tem lados A e B.
            ///


            double AA, BB, CC, trinagulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Entrada:");
            string[] valores = Console.ReadLine().Split(" ");

            AA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            BB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            CC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            trinagulo = AA * CC / 2.0;
            circulo = 3.14159 * (CC * CC);
            trapezio = ((AA + BB) * CC) / 2;
            quadrado = BB * BB;
            retangulo = AA * BB;

            Console.WriteLine("TRINAGULO: {0}", trinagulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
