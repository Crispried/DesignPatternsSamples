using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Adapter
{
    public interface IObjectDestroyer
    {
        void DestroyAllObjects(IEnumerable<object> objects);
    }
}
