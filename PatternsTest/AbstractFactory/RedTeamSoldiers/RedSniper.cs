using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.RedTeamSoldiers
{
    public class RedSniper : ISniper
    {
        public void AimShot()
        {
            Console.WriteLine("I can hit target accurately on the distance 2 km.");
        }
    }
}
