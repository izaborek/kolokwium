using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.rectangle(1,2,2, 3);
            
            Triangle triangle = new Triangle();
            triangle.triangle(1, 2, 5, 6);
            Console.ReadLine();
        }
    }
}
