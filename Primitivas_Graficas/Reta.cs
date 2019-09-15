using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class Reta
    {
        private Ponto inicio, fim;

        public Reta()
        {
        }

        public Reta(Ponto inicio, Ponto fim)
        {
            this.inicio = inicio;
            this.fim = fim;
        }

        internal Ponto Inicio { get => inicio; set => inicio = value; }
        internal Ponto Fim { get => fim; set => fim = value; }
    }
}
