using System;

namespace Ejercicio_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> EsPar = x => (x % 2) == 0;

            Console.WriteLine(EsPar(2));
        }
    }
}
