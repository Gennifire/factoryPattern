using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            else if (shapeType == "circle")
            {
                return new Circle();
            }

            else if (shapeType == "rectangle")
            {
                return new Rectangle();
            }

            else if (shapeType == "square")
            {
                return new Square();
            }
            return null;
        }
    }
}
