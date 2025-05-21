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
        public double PerimetroRectangulo(double l, double a)
        {
            double r = (l * 2) + (a * 2);
            return r;
        }
        public double PerimetroDelCircule(double r)
        {
            double a = 2 * Math.PI * r;
            return a;
        }
    }
}
