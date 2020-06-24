using System;

namespace School
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre, int edad) : base(nombre, edad)
        {
        }

        public void GoToClasses(){
            Console.WriteLine("Voy a clase");
        }

        public override void Saludar()
        {
            Console.WriteLine($"Soy {nombre}. Estudiante de {edad} años");
        }

    }
}