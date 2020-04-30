using System;

namespace S7.CAP88_Demonstracao_expressao_condicional_ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ///*
            ///Resolvendo o problema com if-else:
            ///

            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            ///*
            ///Resolvendo com expressão condicional ternária
            ///
            double preco2 = 34.5;
            double desconto2 = (preco2 < 20.0) ? preco2 * 0.1 : preco2 * 0.05;
        }
    }
}
