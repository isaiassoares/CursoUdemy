using System;

using System.Globalization;
namespace S4.CAP45_Exercicios_propostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;

            f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: {0}", f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario ( porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: {0}", f);

            Console.ReadKey();


        }
    }
}
