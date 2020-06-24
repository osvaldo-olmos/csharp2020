namespace Ejercicio_6._7
{
    public class Triangulo : Figura
    {
        private double lado1;
        private double lado2;

        public Triangulo(string nombre, double _base, double altura, 
            double lado1, double lado2) : base(nombre, _base, altura)
        {
            this.lado1 =lado1;
            this.lado2 =lado2;
        }

        public override double Area()
        {
            return (Base * Altura) / 2;
        }

        public override double Perimetro()
        {
            return Base + lado1 + lado2;
        }
    }
}