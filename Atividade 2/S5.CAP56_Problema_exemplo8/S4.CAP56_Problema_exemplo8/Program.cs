using System;

namespace S4.CAP56_Problema_exemplo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV K4";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
