using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class AET
    {
        private List<No> lista;

        public AET()
        {
            this.lista = new List<No>();
        }

        public void add(No novo)
        {
            if(lista != null)
                lista.Add(novo);
        }

        public void addAll(List<No> nova)
        {
            for (int i = 0; i < nova.Count; i++)
                lista.Add(nova.ElementAt(i));
        }

        public No get(int i)
        {
            return lista.ElementAt(i);
        }

        public List<No> getLista()
        {
            return lista;
        }

        public void ordena()
        {
            for(int i = 0; i < lista.Count; i++)
            {
                for(int j = 0; j < lista.Count - 1; j++)
                {
                    if(lista.ElementAt(j).Ymax == lista.ElementAt(j + 1).Ymax && lista.ElementAt(j).Xmin > lista.ElementAt(j + 1).Xmin)
                    {
                        No aux = lista.ElementAt(j);

                        lista.ElementAt(j).Xmin = lista.ElementAt(j + 1).Xmin;
                        lista.ElementAt(j).Ymax = lista.ElementAt(j + 1).Ymax;
                        lista.ElementAt(j).Incx = lista.ElementAt(j + 1).Incx;

                        lista.ElementAt(j + 1).Xmin = aux.Xmin;
                        lista.ElementAt(j + 1).Ymax = aux.Ymax;
                        lista.ElementAt(j + 1).Incx = aux.Incx;
                    }
                    else if(lista.ElementAt(j).Ymax > lista.ElementAt(j + 1).Ymax)
                    {
                        No aux = lista.ElementAt(j);

                        lista.ElementAt(j).Xmin = lista.ElementAt(j + 1).Xmin;
                        lista.ElementAt(j).Ymax = lista.ElementAt(j + 1).Ymax;
                        lista.ElementAt(j).Incx = lista.ElementAt(j + 1).Incx;

                        lista.ElementAt(j + 1).Xmin = aux.Xmin;
                        lista.ElementAt(j + 1).Ymax = aux.Ymax;
                        lista.ElementAt(j + 1).Incx = aux.Incx;
                    }
                }
            }
        }
    }
}
