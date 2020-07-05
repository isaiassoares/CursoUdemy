using System;
using System.Collections.Generic;
using System.Text;
using S14.CAP200_Heranca_vs_cumprircontrato.Enums;

namespace S14.CAP200_Heranca_vs_cumprircontrato.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
