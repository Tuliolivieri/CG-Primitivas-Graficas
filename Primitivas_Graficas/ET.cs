using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class ET
    {
        private AET[] et;
        private int TF, qtde;

        public ET(int tF)
        {
            TF = tF;
            qtde = 0;
            et = new AET[tF];
        }

        public int getTF()
        {
            return TF;
        }

        public int getQtde()
        {
            return qtde;
        }

        public AET getAET(int i)
        {
            if (i < TF)
                return et[i];
            return null;
        }

        public void inicializa(int i)
        {
            et[i] = new AET();
            qtde++;
        }

        public void addNo(No novo, int i)
        {
            if (et[i] == null)
                inicializa(i);
            et[i].add(novo);
        }
    }
}
