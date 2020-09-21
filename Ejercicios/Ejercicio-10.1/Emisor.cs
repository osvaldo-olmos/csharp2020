using System.Collections.Generic;

namespace Noticias
{
    public delegate void Handler(string message);
    public class Emisor
    {
        private Handler _handler;

        public void Suscribir(Handler handler)
        {
            _handler += handler;
        }

        public void InformarNoticia(string news)
        {
            _handler(news);
        }

    }
}