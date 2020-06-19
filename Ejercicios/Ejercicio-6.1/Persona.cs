using System;

namespace School
{
    public class Persona
    {
        protected int edad;

        public Persona(int edad){
            this.edad = edad;
        }

        public void Saludar(){
            Console.WriteLine("Hola");
        }

        public void ShowAge(){
            Console.WriteLine($"Mi edad es: {edad} años");
        }

    }
}