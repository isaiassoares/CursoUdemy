using System;
using System.Collections.Generic;

namespace S6.CAP83_Exercicio_fixacao_conjunto_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * No portal de cursos online Udemy, cada usuário possui um código único, representado por um número inteiro.
             * Cada instrutor do portal Udemy pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos
             * cursos quiser. Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os
             * cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.
             * O instrutor Joaquim possui três cursos A, B e C, e deseja saber seu número total de alunos.
             * Seu programa deve ler os alunos dos cursos A, B e C do instrutor Joaquim, depois mostrar a quantidade total e alunos dele
             * 
             * 
             * 
             */

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            Console.Write("Quantos alunos possui o curso A? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
            Console.Write("Quantos alunos possui o curso B? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }
            Console.Write("Quantos alunos possui o curso C? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }
            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de Alunos: " + Novo.Count);
            Console.ReadLine();
        }
    }
}
