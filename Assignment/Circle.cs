﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment
{
    public class Circle : Shape
    {
        int radius;//declaration of the radius

        /// <summary>
        /// circle parameterized constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="radius"></param>
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;

        }

        /// <summary>
        /// default circle constructor
        /// </summary>
        public Circle()
        {

        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// circle parameterized constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Circle(int x, int y) : base(x, y)
        {

        }

        /// <summary>
        /// draw method
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawEllipse(p, x, y, radius, radius);
        }


        /// <summary>
        /// radius setter method
        /// </summary>
        /// <param name="radius"></param>
        public void setRadius(int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// radius getter method
        /// </summary>
        /// <returns></returns>
        public int getRadius()
        {
            return this.radius;
        }
    }
}
