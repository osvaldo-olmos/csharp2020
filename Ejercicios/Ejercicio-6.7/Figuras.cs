namespace Ejercicio_6._7
{
    public abstract class Figura
    {
        public string Nombre {get; set;}
        public double Base {get; protected set;}
        public double Altura {get; protected set;}

        public Figura(string nombre, double _base, double altura)
        {
            Nombre =nombre;
            Base =_base;
            Altura =altura;
        }


        public abstract double Area();

        public abstract double Perimetro();
    }
}