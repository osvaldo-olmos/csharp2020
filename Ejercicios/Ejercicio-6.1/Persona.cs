using System;

namespace School
{
    public abstract class Persona
    {
        protected string nombre;
        protected int edad;

        public Persona(string nombre, int edad){
            this.nombre = nombre;
            this.edad = edad;
        }

        public abstract void Saludar();

        public void ShowAge(){
            Console.WriteLine($"Mi edad es: {edad} años");
        }

    }
}