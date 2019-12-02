using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment
{
    public class Polygon : Shape
    {
        public Polygon()
        {

        }

        public PointF[] polygon_vertices { get; set; }

        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(Color.Green, thickness);
            g.DrawPolygon(p, polygon_vertices);
        }
    }
}
