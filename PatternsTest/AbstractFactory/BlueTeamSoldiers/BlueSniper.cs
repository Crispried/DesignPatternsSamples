using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.BlueTeamSoldiers
{
    public class BlueSniper : ISniper
    {
        public void AimShot()
        {
            Console.WriteLine("I can hit target accurately on the distance 1.7 km.");
        }
    }
}
