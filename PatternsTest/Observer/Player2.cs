using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Observer
{
    public class Player2 : PlayerBehaviour, IPlayer
    {
        public void DoAction(PlayerState message)
        {
            MakeDecision(message);
        }
    }
}
