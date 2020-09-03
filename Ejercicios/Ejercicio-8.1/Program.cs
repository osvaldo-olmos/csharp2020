using System;
using System.Collections.Generic;

namespace Ejercicio_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoItWeak();

            DoItBetter();

        }

        private static void DoItBetter()
        {
            Student student = new Student("Juan", "Perez", 40789567, "sistemas");
            student.Study();

            Employee employee = new Employee("John", "Doe", 50142789, "programmer");
            employee.Work();

            StudentAndEmployee student1 = new StudentAndEmployee("Osvaldo", "Olmos", 25000687, "programmer", "sistemas");
            student1.Work();
            student1.Study();

            List<IStudent> students = new List<IStudent>();
            students.Add(student);
            students.Add(student1);
            //students.Add(employee);

            Course course = new Course(students);
        }

        private static void DoItWeak()
        {
            var estudiante = new Estudiante(1, "Pepe", "Sanchez", "Programacion");
            estudiante.Estudiar();
            var empleado = new Empleado(2, "Hector", "Tuga", ",maratonista");
            empleado.Trabajar();
            var estudianteTrabajador = new EstudianteTrabajador(3, "Pepe", "Sanchez", "Programacion", "Carpintero");
            estudianteTrabajador.Estudiar();
            estudianteTrabajador.Trabajar();

            Curso curso = new Curso();

            curso.estudiantes.Add(estudiante);
            curso.estudiantes.Add(estudianteTrabajador);
        }
    }
}
