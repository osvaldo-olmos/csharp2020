using System;

namespace Noticias
{
    class Program
    {
        static void Main(string[] args)
        {
            Emisor emisor =new Emisor();
            Suscriptor sus1 =new Suscriptor();
            Suscriptor sus2 =new Suscriptor();

            emisor.Suscribir(sus1.Informar);
            emisor.Suscribir(sus2.Informar);

            emisor.InformarNoticia("Messi se va");
        }
    }
}
