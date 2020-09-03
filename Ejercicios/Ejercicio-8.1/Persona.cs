using System;
using System.Collections.Generic;

namespace Ejercicio_8._1
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(int ID, string Nombre, string Apellido)
        {

        }

    }

    public class Empleado : Persona
    {
        public Empleado(int ID, string Nombre, string Apellido, 
                        string ocupacion) : base(ID, Nombre, Apellido)
        {
            Ocupacion = ocupacion;

        }
        public string Ocupacion { get; set; }

        public void Trabajar()
        {
            Console.WriteLine($"{ID} trabajando");
        }
    }

    public class Estudiante : Persona
    {
        public Estudiante(int ID, string Nombre, string Apellido, string carrera) : base(ID, Nombre, Apellido)
        {
            Carrera =carrera;
        }

        public string Carrera { get; set; }

        public void Estudiar()
        {
            Console.WriteLine($"{ID} estudiando");
        }
    }

    public class EstudianteTrabajador : Estudiante
    {
        public EstudianteTrabajador(int ID, string Nombre, string Apellido, string carrera, string ocupacion) : base(ID, Nombre, Apellido, carrera)
        {
            Ocupacion =ocupacion;
        }

        //Tengo que duplicar esto porque no puedo heredar de estudiante y trabajador conjuntamente
        public string Ocupacion { get; set; }

        public void Trabajar()
        {
            Console.WriteLine($"{ID} trabajando. Ahora no estoy estudiando");
        }
    }

    public class Curso
    {
        public List<Estudiante> estudiantes { get; set; }
    }

}