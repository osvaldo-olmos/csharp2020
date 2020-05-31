using System;

namespace Ejercicio_3
{
    /**
     * Write a C# Sharp program to print the result of dividing two numbers.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno, numeroDos;

            Console.Write("Ingrese el primer numero: ");
            if (Int32.TryParse(Console.ReadLine(), out numeroUno) != true)
            {
                Console.WriteLine("Numero Invalido");
            }
            else //Es valido
            {
                Console.Write("Ingrese el segundo numero: ");
                if (Int32.TryParse(Console.ReadLine(), out numeroDos) == true && numeroDos != 0)
                {
                    Console.WriteLine("El resultado es: {0}", numeroUno / numeroDos);
                }
                else
                {
                    Console.WriteLine("Numero invalido");

                }
            }
            Console.ReadKey();
        }
    }
}
