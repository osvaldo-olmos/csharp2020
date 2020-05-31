using System;

namespace Ejercicio_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Ingresa tu nombre : ");
            nombre = Console.ReadLine();

            Console.WriteLine("REEMPLAZO VOCAL A: " + nombre.Replace("A", "X"));
            Console.WriteLine("REEMPLAZO VOCAL a: " + nombre.Replace("a", "x"));
            Console.WriteLine("EN MINUSCULAS : " + nombre.ToLower());
            Console.WriteLine("EN MAYÚSCULAS : " + nombre.ToUpper());
            Console.WriteLine("REMOVER 4 LETRAS : " + nombre.Remove(3, 4));
            Console.WriteLine("EXTRAER 4 LETRAS : " + nombre.Substring(3, 4));
            Console.WriteLine("IZQUIERDA 4 LETRAS : " + LeftToRight(nombre, 4));
            Console.WriteLine("DERECHA 4 LETRAS : " + RightToLeft(nombre, 4));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("DESDE LA IZQUIERDA");
            for (int k = 1; k <= nombre.Length; k++)
            {
                Console.WriteLine(LeftToRight(nombre, k));
            }
            Console.WriteLine();
            Console.WriteLine("DESDE LA DERECHA");
            for (int k = 1; k <= nombre.Length; k++)
            {
                Console.WriteLine(RightToLeft(nombre, k));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static string LeftToRight(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string RightToLeft(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }

    }

}
