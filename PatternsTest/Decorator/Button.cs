using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Decorator
{
    public class Button : IComponent
    {
        public void draw()
        {
            Console.WriteLine("Button draw");
        }
    }
}
