using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(6, 7, '#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(5, 10, 8, '+');
            hline.Draw();

            VerticalLine vline = new VerticalLine(4, 2, 8, '+');
            vline.Draw();

            Console.ReadLine();
        }
    }
}
