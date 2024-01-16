using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tocka
{
    internal class Krug
    {
        private double radius;
        private Tocka srediste;

        public Krug(double x, double y, double r)
        {
            radius = r;
            srediste = new Tocka(x, y);
        }

        public bool dodir(Krug K1, Krug K2)
        {
            double l = K1.srediste.udaljenost(srediste);

            if (l <= (K2.radius + K1.radius))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
