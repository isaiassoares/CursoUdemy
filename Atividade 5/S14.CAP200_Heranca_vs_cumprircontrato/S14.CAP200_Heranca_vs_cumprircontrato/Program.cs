using System;
using S14.CAP200_Heranca_vs_cumprircontrato.Entities;
using S14.CAP200_Heranca_vs_cumprircontrato.Enums;

namespace S14.CAP200_Heranca_vs_cumprircontrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
