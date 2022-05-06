using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Poligon_recurenta_05._05
{
    public class Point
    {
        public float x, y;
        Random rnd = new Random();
        public Point(float x, float y)
        {
            this.x = (float)(rnd.NextDouble() * x); this.y = (float)(rnd.NextDouble() * y);
        }

        public void draw(Graphics grp)
        {
            grp.DrawEllipse(Pens.Black, x - 3, y - 3, 7, 7);
        }


    }
}
