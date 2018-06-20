using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Observer
{
    public abstract class PlayerBehaviour
    {
        private void StartMove()
        {
            Console.WriteLine(this + " Now its my Turn");
        }
        private void EndMove()
        {
            Console.WriteLine(this + "My turn was ended");
        }
        public void MakeDecision(PlayerState message)
        {
            switch (message)
            {
                case PlayerState.Moving:
                    this.StartMove();
                    break;
                case PlayerState.Waiting:
                    this.EndMove();
                    break;
            }
        }
    }
}
