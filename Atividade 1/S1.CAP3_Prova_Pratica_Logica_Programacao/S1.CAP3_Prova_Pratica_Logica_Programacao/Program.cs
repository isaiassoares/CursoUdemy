using System;
using System.Globalization;

namespace S1.CAP3_Prova_Pratica_Logica_Programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1: ESTRUTURA SEQUENCIAL
            //Exercicio 1.1:
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago

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



            //Excercicio 1.2:
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            //casas decimais conforme exemplos.
            //Fórmula: area = π.raio²
            //Considere o valor de π = 3.14159

            double raio, area, pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (raio * raio) * pi;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();



            //PARTE 2 ESTRUTURA CONDICIONAL
            //Exercício 2.1:
            //Com base na tabela de preços ao lado, faça um programa que leia o código de um item e a
            //quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar

            int codItem, qtdItem;
            double total = 0.0;

            Console.WriteLine("Informe o numero do Item:");
            codItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade:");
            qtdItem = int.Parse(Console.ReadLine());

            if (codItem == 1)
            {
                total = 4.00 * qtdItem;
            }
            if (codItem == 2)
            {
                total = 4.50 * qtdItem;
            }
            if (codItem == 3)
            {
                total = 5.00 * qtdItem;
            }
            if (codItem == 4)
            {
                total = 2.00 * qtdItem;
            }
            if (codItem == 5)
            {
                total = 1.50 * qtdItem;
            }

            Console.WriteLine("Total: " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

            //Exercício 2.2:
            //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau.
            //Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara
            //Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
            //negativo), mostrar uma mensagem "Impossivel calcular".

            double a, b, c;
            double delta, x1, x2;

            Console.WriteLine("Informe os valores: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            if (a != 0 && delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("X1 = {0}", x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = {0}", x2.ToString("F5", CultureInfo.InvariantCulture));
            }
            else Console.WriteLine("Impossivel calcular");

            Console.ReadKey();


            //PARTE 3 ESTRUTURAS REPETITIVAS
            //Exercício 3.1
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            Console.Write("Informe a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("-------------------");
                Console.WriteLine("Informe a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

            Console.ReadKey();


            //Execrcicio 3.2:
            //Leia um valor inteiro N.Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            int dentro = 0, fora = 0;

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro = dentro + 1;
                }
                else fora = fora + 1;

            }

            Console.WriteLine("{0} in", dentro);
            Console.WriteLine("{0} out", fora);


            Console.ReadKey();
        }
    }
}
