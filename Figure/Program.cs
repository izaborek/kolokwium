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
            Console.WriteLine("Punkty prostokąta :");
            rectangle.rectangle(1,2,2, 3);
            
            Triangle triangle = new Triangle();
            Console.WriteLine("Punkty trójkąta :");
            triangle.triangle(1, 2, 5, 6);
            Console.ReadLine();
        }
    }
}
