using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsTest.AbstractFactory.RedTeamSoldiers;

namespace PatternsTest.AbstractFactory
{
    public class RedTeamFactory : ISoldierFactory
    {
        public IHeavy CreateHeavy()
        {
            return new RedHeavy();
        }
        public IAssault CreateAssault()
        {
            return new RedAssault();
        }
        public ISniper CreateSniper()
        {
            return new RedSniper();
        }
    }
}
