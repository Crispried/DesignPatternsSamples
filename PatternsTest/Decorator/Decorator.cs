using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Decorator
{
    public abstract class Decorator : IComponent
    {
        protected IComponent component;
        public Decorator(IComponent component)
        {
            this.component = component;
        }
        public abstract void afterDraw();
        public void draw()
        {
            component.draw();
            afterDraw();
        }
    }
}
