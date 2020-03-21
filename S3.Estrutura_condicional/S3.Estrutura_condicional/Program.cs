using System;

namespace S3.Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstração:
            //Entre com um número inteiro:
            //  10
            //Par!
            //Entre com um número ímpar ?
            //  15
            //Ímpar!

            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            //Demonstração 2:
            //Qual a hora atual?
            //  10
            //Bom dia!
            // hora < 12

            //Qual a hora atual?
            // 14
            //Boa tarde!
            //12<=hora <18

            //Qual a hora atual?
            //  19
            //Boa noite!
            //hora >=18

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
