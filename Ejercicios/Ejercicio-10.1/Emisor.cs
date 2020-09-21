using System.Collections.Generic;

namespace Noticias
{
    public class Emisor
    {
        List<Suscriptor> suscriptores = new List<Suscriptor>();
        public void Suscribir(Suscriptor suscriptor)
        {
            suscriptores.Add(suscriptor);
        }

        public void InformarNoticia(string news)
        {
            foreach (var item in suscriptores)
            {
                item.Informar(news);
            }
        }

    }
}