using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Observer
{
    public class GameController : IGameController
    {
        private List<IPlayer> Players = new List<IPlayer>();
        public List<IPlayer> GetAllPlayers()
        {
            return Players;
        }
        public void AddPlayer(IPlayer player)
        {
            Players.Add(player);
        }
        public void RemovePlayer(IPlayer player)
        {
            Players.Remove(player);
        }
        public void RemoveAllPlayers()
        {
            Players.Clear();
        }
        public void NotifyPlayer(PlayerState message, IPlayer player)
        {
            player.DoAction(message);
        }
    }
}
