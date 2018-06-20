using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsTest.AbstractFactory.BlueTeamSoldiers;

namespace PatternsTest.AbstractFactory
{
    public class BlueTeamFactory : ISoldierFactory
    {
        public IHeavy CreateHeavy()
        {
            return new BlueHeavy();
        }
        public IAssault CreateAssault()
        {
            return new BlueAssault();
        }
        public ISniper CreateSniper()
        {
            return new BlueSniper();
        }
    }
}
