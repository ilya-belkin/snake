using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public Snake(Point tail, int length, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;

            for (int i = 0; i < length; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                pList.Add(p);
            }
        }

        internal void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
