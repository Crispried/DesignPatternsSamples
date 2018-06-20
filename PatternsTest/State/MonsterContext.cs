using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.State
{
    public class MonsterContext : IMonsterState
    {
        private IMonsterState State;
        public IMonsterState GetState()
        {
            return State;
        }
        public void SetState(IMonsterState state)
        {
            State = state;
        }
        public void Action()
        {
            this.State.Action();
        }
    }
}
