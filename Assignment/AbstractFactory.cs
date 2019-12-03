using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{   /// <summary>
/// AbstractFactory Class
/// </summary>
    public abstract class AbstractFactory
    {   /// <summary>
    /// Shape 
    /// </summary>
    /// <param name="shapeType"></param>
    /// <returns></returns>
        public abstract Shape getShape(String shapeType);
    }
}
