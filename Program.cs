using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Krug jedan = new Krug(1, 2, 3);
            Krug dva = new Krug(1, 2, 3);

            Console.WriteLine(jedan.dodir(jedan, dva));

            Console.ReadKey();
        }
    }
}
