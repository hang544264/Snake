using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// class拷贝引用 struct拷贝内容
    /// </summary>
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
