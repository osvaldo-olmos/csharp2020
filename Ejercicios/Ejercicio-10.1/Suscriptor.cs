using System;
using System.Collections.Generic;

namespace Noticias
{
    public class Suscriptor
    {
        public string Nombre { get; set; }

        public void Informar(string news)
        {
            Console.WriteLine($"ATENNNCION!: {news}");
        }
    }
}