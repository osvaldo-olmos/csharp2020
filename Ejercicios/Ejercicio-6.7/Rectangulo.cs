namespace Ejercicio_6._7
{
    public class Rectangulo : Figura
    {
        public Rectangulo(string nombre, double _base, double altura) : base(nombre, _base, altura)
        {
        }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            throw new System.NotImplementedException();
        }
    }
}