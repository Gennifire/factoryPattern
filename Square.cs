using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern
{
    class Square : Shape
    {
        
        public void Draw()
        {
            Console.WriteLine("I am in the Square :: Draw() method");
        }
    }
}
