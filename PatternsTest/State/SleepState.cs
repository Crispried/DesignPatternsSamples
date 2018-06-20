using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.State
{
    public class SleepState : IMonsterState
    {
        public void Action()
        {
            Console.WriteLine("I am sleeping");
        }
    }
}
