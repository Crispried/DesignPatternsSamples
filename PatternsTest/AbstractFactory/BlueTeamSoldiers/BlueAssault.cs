using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.BlueTeamSoldiers
{
    public class BlueAssault : IAssault
    {
        public void FastShot()
        {
            Console.WriteLine("I produce 12 shots in sec");
        }
    }
}
