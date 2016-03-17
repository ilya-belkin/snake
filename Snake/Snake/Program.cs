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
            Console.SetBufferSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            upLine.Draw();
            rightLine.Draw();
            downLine.Draw();
            leftLine.Draw();

            Point p = new Point(5, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
