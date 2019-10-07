using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitivas_Graficas
{
    class No
    {
        private double xmin, ymax, incx;

        public No(double xmin, double ymax, double incx)
        {
            this.xmin = xmin;
            this.ymax = ymax;
            this.incx = incx;
        }

        public double Xmin { get => xmin; set => xmin = value; }
        public double Ymax { get => ymax; set => ymax = value; }
        public double Incx { get => incx; set => incx = value; }
    }
}
