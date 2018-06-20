using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Strategy
{
    public class ModeController
    {
        public void CreateGame(IGameMode gameMode)
        {
            gameMode.CreateGame();
        }
    }
}
