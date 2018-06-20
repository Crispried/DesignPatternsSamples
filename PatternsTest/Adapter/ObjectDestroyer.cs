using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Adapter
{
    // it's our external class, we can't modify it,
    // so that will be our 'adaptee' object
    public class ObjectDestroyer 
    {
        public void DestroyObject(object obj)
        {
            Console.WriteLine(obj + " was destroyed");
        }
    }
}
