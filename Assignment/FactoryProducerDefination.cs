﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// Factory Producer Defination
/// </summary>
    public class FactoryProducerDefination
    {
        /// <summary>
        /// checks whether the type is shape or color
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool isShape(string type)
        {
            if (type == "shape")
            {
                return true;
            }
            return false;
        }
    }
}
