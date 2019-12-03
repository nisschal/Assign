﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// Rectangle Class
/// </summary>
    public class Rectangle : Shape
    {
        //declaration of variables
        int height, width;


        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public Rectangle(int x, int y, int height, int width) : base(x, y)
        {
            this.height = height;
            this.width = width;
        }


        /// <summary>
        /// another parameterized constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Rectangle(int x, int y) : base(x, y)
        {

        }


        /// <summary>
        /// default constructor
        /// </summary>
        public Rectangle()
        {
        }


        /// <summary>
        /// draw method
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawRectangle(p, x, y, height, width);
        }


        /// <summary>
        /// height setter
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(int height)
        {
            this.height = height;
        }


        /// <summary>
        /// height getter
        /// </summary>
        /// <returns></returns>
        public int getHeight()
        {
            return this.height;
        }

        /// <summary>
        /// width setter
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(int width)
        {
            this.width = width;
        }


        /// <summary>
        /// width getter
        /// </summary>
        /// <returns></returns>
        public int getWidth()
        {
            return this.width;
        }
    }
}
