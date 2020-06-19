using System;

namespace School
{
    public class Estudiante : Persona
    {
        public Estudiante(int edad) : base(edad)
        {
        }

        public void GoToClasses(){
            Console.WriteLine("Voy a clase");
        }

    }
}