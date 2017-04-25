using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle
    {
         public void triangle(int x, int y, int podstawa, int h)
        {

            int drugax = x + podstawa;
            int trzeciax = x + podstawa / 2;
            int trzeciay = y + h;
            Console.WriteLine("(" + x + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + y + ")");
            Console.WriteLine("(" + trzeciax + "," + trzeciay + ")");

        }
    }
}
