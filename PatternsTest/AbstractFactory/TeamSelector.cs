using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.AbstractFactory
{
    public class TeamSelector
    {
        private static TeamSelector Instance;
        private TeamSelector() { }
        public static TeamSelector GetInstance()
        {
            if(Instance == null)
            {
                Instance = new TeamSelector();
            }
            return Instance;
        }
        public ISoldierFactory GetTeam(TeamColour teamColour)
        {
            ISoldierFactory Team = null;
            switch (teamColour)
            {
                case TeamColour.Red:
                    Team = new RedTeamFactory();
                    break;
                case TeamColour.Blue:
                    Team = new BlueTeamFactory();
                    break;
            }
            return Team;
        }
    }
}
