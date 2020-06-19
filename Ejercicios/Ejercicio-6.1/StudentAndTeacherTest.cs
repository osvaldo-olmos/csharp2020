using System;

namespace School
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(15);

            p1.Saludar();

            Estudiante e1 = new Estudiante(21);
            
            e1.Saludar();
            e1.ShowAge();

            Profesor profe1 = new Profesor(30,"Programacion");

            profe1.ShowAge();
            profe1.Saludar();
            profe1.Explicar();


        }
    }
}
