using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth, mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        internal Point CreateFood()
        {
            int y = random.Next(2, mapHeight - 2);
            int x = random.Next(2, mapWidth - 2);
            return new Point(x, y, sym);
        }
    }
}
