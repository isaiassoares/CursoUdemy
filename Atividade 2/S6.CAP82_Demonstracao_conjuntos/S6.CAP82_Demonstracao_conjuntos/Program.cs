using System;
using System.Collections.Generic;

namespace S6.CAP82_Demonstracao_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            foreach (int x in B)
            {
                Console.WriteLine(x);
            }



            Console.ReadLine();
        }
    }
}
