using System;
using System.Globalization;

namespace S4.CAP40_Primeiros_exercícios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("EXERCÍCIO 1 ------------------------------------------------");
            Console.WriteLine("");
            ///EXERCÍCIO 01:
            ///Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
            ///

            Pessoa cadastro1, cadastro2;

            cadastro1 = new Pessoa();
            cadastro2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            cadastro1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            cadastro1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            cadastro2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            cadastro2.Idade = int.Parse(Console.ReadLine());

            if(cadastro1.Idade > cadastro2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: {0}", cadastro1.Nome);
            }
            else{
                Console.WriteLine("Pessoa mais velha: {0} ", cadastro2.Nome);
            }


            Console.WriteLine("");
            Console.WriteLine("EXERCÍCIO 2 ------------------------------------------------");
            Console.WriteLine("");
            ///EXERCÍCIO 02:
            ///Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário médio dos funcionários.

            Funcionario func1, func2;

            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (func1.Salario + func2.Salario) / 2.0;

            Console.WriteLine("Salário médio = {0}", media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
