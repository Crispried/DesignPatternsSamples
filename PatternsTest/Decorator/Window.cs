using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Decorator
{
    public class Window : IComponent
    {
        public void draw()
        {
            Console.WriteLine("Window draw");
        }
    }
}
