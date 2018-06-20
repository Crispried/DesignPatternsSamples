using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Facade
{
    public class Mission
    {
        private Scout Scout = new Scout();
        private Sniper Sniper = new Sniper();
        private Base Base = new Base();
        public void MakeTheMission()
        {
            Scout.LookingForTarget();
            Sniper.Aiming();
            Base.Firing();
        }
    }
}
