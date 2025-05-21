using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyejemplClass09
{
    public class Areas
    {
        //muchos metotodos
        public double AreaCuadrado(double l)
        {
            double a;
            a = l * l;
            return a;
        }
        public double AreaTriangulo(double b, double h)
        {
            return (b * h) / 2;
        }
        public double AreaRectangulo(double l, double a)
        {
            double r;
            r = l * a;
            return r;
        }
        public double AreaCirculo(double r)
        {
            double a = Math.PI * (r * r);
            return a;
        }
    }
}
