using System;

namespace Ejercicio_5
{
    // Write a C# Sharp program to swap two numbers. 
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, auxiliar;

            Console.WriteLine("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            auxiliar =numero2;
            numero2 =numero1;

            numero1 =auxiliar;

            Console.WriteLine($"Número uno es:{numero1}");
            Console.WriteLine($"Número dos es:{numero2}");
        }
    }
}
