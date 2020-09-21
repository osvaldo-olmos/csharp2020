using System;
using System.Collections.Generic;

namespace Noticias
{
    public class Suscriptor
    {
        public string Nombre { get; set; }

        public void Informar(object sender, string news)
        {
            var publisher =sender as Emisor;
            if(publisher ==null){
                Console.WriteLine("Todo maaaal no reconozco el tipo del Emisor");
                return;
            }

            Console.WriteLine($"ATENNNCION!: {news}");
        }
    }
}