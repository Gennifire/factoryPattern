using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Rectangle : Shape
    {
        
        public void Draw()
        {
            Console.WriteLine("I am in the Rectangle :: Draw method");
        }
    }
}
