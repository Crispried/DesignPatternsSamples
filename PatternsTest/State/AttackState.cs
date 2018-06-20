using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.State
{
    public class AttackState : IMonsterState
    {
        public void Action()
        {
            Console.WriteLine("I am attacking");
        }
    }
}
