using System;

namespace School
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            // Persona p1 = new Persona("Pedro", 15);

            // p1.Saludar();

            Estudiante e1 = new Estudiante("Jose", 21);
            Estudiante e2 = new Estudiante("Jose", 21);
            
            Console.WriteLine(e1.Equals(e2));
            Console.WriteLine(e1.GetHashCode());
            Console.WriteLine(e2.GetHashCode());

            e1.Saludar();
            e1.ShowAge();

            Profesor profe1 = new Profesor("Murray", 30,"Programacion");

            profe1.ShowAge();
            profe1.Saludar();
            profe1.Explicar();


        }
    }
}
