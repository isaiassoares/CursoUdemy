using S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities.Enums;

namespace S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
