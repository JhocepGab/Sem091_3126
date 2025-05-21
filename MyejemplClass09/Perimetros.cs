using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyejemplClass09
{
    public class Perimetros
    {
        //metodo para rectanguloo
        //para el circulo 
        public void PerimetroRectangulo(double l, double a, ref double p)
        {
            p = 2 * (l + a);
        }
        public void PerimetroDelCircule(double r, ref double p)
        {
            p = 2 * Math.PI * r;
        }
    }
}
