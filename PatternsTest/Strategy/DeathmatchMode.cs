using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Strategy
{
    public class DeathmatchMode : IGameMode
    {
        public void CreateGame()
        {
            Console.WriteLine("The deathmatch mode game was created");
        }
    }
}
