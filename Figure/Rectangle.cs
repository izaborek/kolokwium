﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public  class Rectangle
    {

        //public double Podajpunkty(int pierwsza, int druga, int x, int y)
        //{
        //    int xo = pierwsza;
        //    int yo = druga;
        //    Console.WriteLine("(" + xo + "," + yo + ")");
        //    for (int i = xo; i <=druga; i++)
        //    {
        //        x = x + i;
        //        Console.WriteLine("(" + x + "," + y + ")");

        //    }
        //    return x;
        //}

         public void rectangle(int x, int y, int bok1, int bok2)
        {

            int drugax = x + bok1;
            int drugay = y + bok2;
            Console.WriteLine("(" + x + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + y + ")");
            Console.WriteLine("(" + drugax + "," + drugay + ")");
            Console.WriteLine("(" + x + "," + drugay + ")");
        }


    }
}
