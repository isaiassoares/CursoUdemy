using System;
using System.Collections.Generic;
using System.Text;
using S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities.Enums;

namespace S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
