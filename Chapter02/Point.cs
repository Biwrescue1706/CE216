using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Point
    {
        public int x;
        public int y;

        public Point()
        {
            x = 1; 
            y = 2;
        }
        public Point(int x, int y)
        {
            this.x = x;//this คือ การเรียกใช้โกบอล
            this.y = y;
        }
    }
}
