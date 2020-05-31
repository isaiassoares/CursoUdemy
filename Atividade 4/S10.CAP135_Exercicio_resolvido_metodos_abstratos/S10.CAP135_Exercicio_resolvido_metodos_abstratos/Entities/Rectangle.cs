using S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities.Enums;

namespace S10.CAP135_Exercicio_resolvido_metodos_abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width*Height;
        }

    }
}
