using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Circle : Shape
    {
       
        public void Draw()
        {
            Console.WriteLine("I'm inside the circle :: Draw() method.");
        }
    }
}
