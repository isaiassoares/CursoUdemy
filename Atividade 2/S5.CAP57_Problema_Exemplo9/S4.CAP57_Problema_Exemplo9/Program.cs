using System;

namespace S4.CAP57_Problema_Exemplo9
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
