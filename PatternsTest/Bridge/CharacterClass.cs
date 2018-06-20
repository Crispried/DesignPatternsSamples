using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Bridge
{
    public abstract class CharachterClass
    {
        protected string ClassName;
        public string GetClass
        {
            get
            {
                return ClassName;
            }
        }
    }
}
