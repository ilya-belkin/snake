using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yup, int ydown, char sym)
        {
            pList = new List<Point>();
            for (int y = yup; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
