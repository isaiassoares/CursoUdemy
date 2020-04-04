﻿using System;

namespace S6.CAP71_Exercicio_fixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A dona de um pensionato possui dez quartos para alugar para estudantes,
             * sendo esses quartos identificados pelos números 0 a 9.
             * Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
             * Fazer um programa que inicie com todos os dez quartos vazios, e depois
             * leia uma quantidade N representando o número de estudantes que vão alugar quartos 
             * (N pode ser de 1 a 10). Em seguida, registre o aluguel dos N estudantes. 
             * Para cada registro de aluguel, informar o nome e email do estudante, bem como qual dos quartos 
             * ele escolheu (de 0 a 9). Suponha que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
             * um relatório de todas ocupações do pensionato, por ordem de quarto, conforme exemplo.
             * 
             */

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
          

            Estudante[] vetor = new Estudante[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}", i+1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante {Nome= nome, Email = email};
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int j = 0; j < 10; j++)
            {
                if(vetor[j] != null)
                {
                    Console.WriteLine("{0}: {1}",j,vetor[j]);
                }
            }

            Console.ReadKey();

        }
    }
}
