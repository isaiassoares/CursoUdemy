using System;

namespace S4.CAP45_Exercicios_propostos1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        
        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
