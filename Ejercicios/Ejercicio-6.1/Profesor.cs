using System;

namespace School
{
    public class Profesor : Persona
    {
        private string materia;

        public Profesor(string nombre, int edad,string materia) : base(nombre, edad)
        {
            this.materia = materia;
        }

        public void Explicar(){
            Console.WriteLine($"comienza la explicación la materia: {materia}");
        }

        public override void Saludar()
        {
            Console.WriteLine($"Soy {nombre}. Profesor de la materia: {materia}");
        }
    }
}