using System;
using System.Globalization;

namespace S3.Ex_saidas_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            //Demostração
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            //Placeholders, concatenação e interpolação
            int idade2 = 32;
            double saldo2 = 10.35784;
            String nome2 = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2); //Placeholders
            Console.WriteLine($"{nome2} tem {idade2} anos e tem saldo igual a {saldo2:F2} reais"); //concatenação
            Console.WriteLine(nome2 + " tem " + idade2 + " anos e tem saldo igual a "+ saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //interpolação
        
        }
    }
}
