﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += offset;
            else if (direction == Direction.LEFT)
                x -= offset;
            else if (direction == Direction.UP)
                y += offset;
            else if (direction == Direction.DOWN)
                y -= offset;
        }
    }
}
