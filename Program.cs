using System;

namespace factoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //Get the circle
            Shape firstShape = shapeFactory.getShape("circle");
            firstShape.Draw();


            //get the rectangle
            Shape secondShape = shapeFactory.getShape("rectangle");
            secondShape.Draw();

            //get the square
            Shape thirdShape = shapeFactory.getShape("rectangle");
            thirdShape.Draw();
        }
    }
}
