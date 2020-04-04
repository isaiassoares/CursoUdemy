using System;
using System.Globalization;

namespace S2.CAP45_Exercicios_propostos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = {0}", a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();

        }
    }
}
