using System;
using System.Globalization;

namespace S3.Exercício_de_fixacao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Em um novo programa, inicie as seguintes variáveis:
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;
            //-----------------------------------------------------------------------------------------------
            //Em seguida, usando os valores das variáveis, produza a seguinte saída na tela do console:
            // Produtos:
            // Computador, cujo preço é $ 2100,00
            //Mesa de escritório, cujo preco é $ 650,50

            //Registro: 30 anos de idade, código 5290 e gênero: M

            //Medida com oito casas decimais: 53,23456700
            //Arredondado(três casas decimais): 53,235
            //Separador decimal invariant culture: 53.235

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
