using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Adapter
{
    public class ObjectDestroyerAdapter : IObjectDestroyer
    {
        private ObjectDestroyer ObjectDestroyer = new ObjectDestroyer();

        public void DestroyAllObjects(IEnumerable<object> objects)
        {
            foreach(object obj in objects)
            {
                ObjectDestroyer.DestroyObject(obj);
            }
        }
    }
}
