using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Decorator
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(IComponent component) : base(component)
        {
        }
        public override void afterDraw()
        {
            Console.WriteLine("...added border");
        }
    }
}
