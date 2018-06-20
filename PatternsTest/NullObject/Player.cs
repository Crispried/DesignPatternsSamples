using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.NullObject
{
    public class Player : ISpeakable
    {
        public void WritePostMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
