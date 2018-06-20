using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.BlueTeamSoldiers
{
    public class BlueHeavy : IHeavy
    {
        public void LaunchRocket()
        {
            Console.WriteLine("I am launching a rocket that hits on 12 cells and deals 190 damage in this radius.");
        }
    }
}
