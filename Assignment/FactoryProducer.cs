﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FactoryProducer
    {
        /// <summary>
        /// method to create factory of different type like shape, color
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static AbstractFactory getFactory(String choice)
        {
            //if condition to check if choice is shape or color
            if (choice.Equals("Shape"))
            {
                return new ShapeFactory();
            }

            return null;
        }
    }
}
