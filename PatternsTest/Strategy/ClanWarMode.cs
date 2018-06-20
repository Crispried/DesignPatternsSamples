using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Strategy
{
    public class ClanWarMode : IGameMode
    {
        public void CreateGame()
        {
            Console.WriteLine("The clan war mode game was created");
        }
    }
}
