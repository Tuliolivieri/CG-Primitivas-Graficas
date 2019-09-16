using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class Poligono
    {
        private List<Ponto> vertices;
        private List<Ponto> original;
        private double[,] MA;

        public Poligono()
        {
            vertices = new List<Ponto>();
            original = new List<Ponto>();

            MA = new double[3, 3];
            MA[0, 0] = 1;
            MA[0, 1] = 0;
            MA[0, 2] = 0;
            MA[1, 0] = 0;
            MA[1, 1] = 1;
            MA[1, 2] = 0;
            MA[2, 0] = 0;
            MA[0, 1] = 0;
            MA[2, 2] = 1;
        }

        internal List<Ponto> Vertices { get => vertices; set => vertices = value; }
        internal List<Ponto> Original { get => original; set => original = value; }

        public double[,] getMA()
        {
            return MA;
        }

        public void setMA(double[,] MA)
        {
            this.MA = MA;
        }

        public void addVertice(Ponto vertice)
        {
            vertices.Add(vertice);
        }

        public void addOriginal(Ponto vertice)
        {
            original.Add(vertice);
        }

        public bool isFechado()
        {
            return vertices.Count > 1 && vertices.First().X == vertices.Last().X && vertices.First().Y == vertices.Last().Y;
               
        }
    }
}
