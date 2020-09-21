using System;
using System.Collections.Generic;

namespace Noticias
{
    
    public class Emisor
    {
        private event EventHandler<string> _handler;

        public void Suscribir(EventHandler<string> handler)
        {
            _handler += handler;
        }

        public void InformarNoticia(string news)
        {
            _handler?.Invoke(this, news);
        }

    }
}