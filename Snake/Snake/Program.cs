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

            List<Point> pList = new List<Point>();

            Point p3 = new Point(2, 4, '@');
            Point p4 = new Point(5, 2, '$');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadLine();
        }
    }
}
