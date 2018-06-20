using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Decorator
{
    public class ColourDecorator : Decorator
    {
        public ColourDecorator(IComponent component) : base(component)
        {         
        }
        public override void afterDraw()
        {
            Console.WriteLine("...added colour");
        }
    }
}
