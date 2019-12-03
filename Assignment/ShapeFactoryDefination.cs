﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// Shape Conditions
/// </summary>
    public class ShapeFactoryDefination
    {
        /// <summary>
        /// method to check if shape is circle
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public bool isCircle(string shape)
        {
            if (shape != "Circle")
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// method to check if shape is rectangle
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public bool isRectangle(string shape)
        {
            if (shape == "Rectangle")
            {
                return true;
            }
            return false;
        }

        public bool isTriangle(string shape)
        {
            if (shape == "Triangle")
            {
                return true;
            }
            return false;
        }
    }
}
