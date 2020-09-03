using System;

namespace Ejercicio_8._1
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

    public class Empleado : Persona
    {
        public string Ocupacion { get; set; }

        public void Trabajar()
        {
            Console.WriteLine($"{ID} trabajando");
        }
    }

    public class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public void Estudiar()
        {
            Console.WriteLine($"{ID} estudiando");
        }
    }

}