using System;

namespace Ejercicio_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante = new Estudiante(1, "Pepe", "Sanchez", "Programacion");
            var empleado = new Empleado(2, "Hector", "Tuga", ",maratonista");
            var estudianteTrabajador = new EstudianteTrabajador(3, "Pepe", "Sanchez", "Programacion", "Carpintero");

            Curso curso =new Curso();

            curso.estudiantes.Add(estudiante);
            curso.estudiantes.Add(estudianteTrabajador);
        }
    }
}
