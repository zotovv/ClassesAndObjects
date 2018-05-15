using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Point
    {
        int x;
        int y;
        string name;

        public int X
        {
            get => x;
        }

        public int Y
        {
            get => y;
        }

        public string Length
        {
            get => name;
        }

        public Point(int x, int y, string length)
        {
            this.x = x;
            this.y = y;
            this.name = length;
        }
    }
}
