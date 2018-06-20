using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory.RedTeamSoldiers
{
    public class RedAssault : IAssault
    {
        public void FastShot()
        {
            Console.WriteLine("I produce 10 shots in sec");
        }
    }
}
