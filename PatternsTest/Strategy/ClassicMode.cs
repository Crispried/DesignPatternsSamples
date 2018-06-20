using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Strategy
{
    public class ClassicMode : IGameMode
    {
        public void CreateGame()
        {
            Console.WriteLine("The classic mode game was created");
        }
    }
}
