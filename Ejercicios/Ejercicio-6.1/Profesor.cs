using System;

namespace School
{
    public class Profesor : Persona
    {
        private string materia;

        public Profesor(int edad,string materia) : base(edad)
        {
            this.materia = materia;
        }

        public void Explicar(){
            Console.WriteLine($"comienza la explicación la materia: {materia}");
        }
    }
}