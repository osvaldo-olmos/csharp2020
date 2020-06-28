using System;

namespace Ejercicio_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantTablas, resultado;
            Console.Write("Ingrese cantidad de tablas: ");
            cantTablas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantTablas; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine($"{i} * {j} = {resultado}", i, j, resultado);
                }
                Console.Write("Pulse una Tecla:");
                Console.ReadLine();
            }
            Console.Write("F I N");
        }
    }
}
