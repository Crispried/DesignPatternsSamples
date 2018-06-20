using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.RedTeamSoldiers
{
    public class RedHeavy : IHeavy
    {
        public void LaunchRocket()
        {
            Console.WriteLine("I am launching a rocket that hits on 10 cells and deals 200 damage in this radius.");
        }
    }
}
