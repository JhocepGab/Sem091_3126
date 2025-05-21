using MyejemplClass09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Perimetros p = new Perimetros();
            double b, r, h;
            b = 5;
            h = 10;
            r = 0;
            p.PerimetroRectangulo(b, h, ref r);

            Console.WriteLine("R3" + p);
        }
    }
}
