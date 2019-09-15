using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class Circulo
    {
        private Ponto centro;
        private int raio;

        public Circulo(Ponto centro, int raio)
        {
            this.centro = centro;
            this.raio = raio;
        }

        public int Raio { get => raio; set => raio = value; }
        internal Ponto Centro { get => centro; set => centro = value; }
    }
}
