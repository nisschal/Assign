using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// Polygon Class
/// </summary>
    public class Polygon : Shape
    {   /// <summary>
    /// Constructor
    /// </summary>
        public Polygon()
        {

        }
        /// <summary>
        /// Vertices Taken
        /// </summary>
        public PointF[] polygon_vertices { get; set; }
        /// <summary>
        /// Drawing Polygon
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        /// <param name="thickness"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(Color.Green, thickness);
            g.DrawPolygon(p, polygon_vertices);
        }
    }
}
