using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// Line Class Initiation 
/// </summary>
    class Line : Shape
    {
        int x1, x2, y1, y2;
        /// <summary>
        /// Parameters
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        public Line(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        /// <summary>
        /// 
        /// </summary>
        public Line()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1"></param>
        public void setX1(int x1)
        {
            this.x1 = x1;
        }
        /// <summary>
        /// a
        /// </summary>
        /// <returns></returns>
        public int getX1()
        {
            return x1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x2"></param>
        public void setX2(int x2)
        {
            this.x2 = x2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getX2()
        {
            return x2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="y1"></param>
        public void setY1(int y1)
        {
            this.y1 = y1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getY1()
        {
            return y1;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="y2"></param>
        public void setY2(int y2)
        {
            this.y2 = y2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getY2()
        {

            return y2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        /// <param name="thickness"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawLine(p, x1, y1, x2, y2);
        }
    }
}
