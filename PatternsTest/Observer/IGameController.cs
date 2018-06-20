using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Observer
{
    public interface IGameController
    {
        List<IPlayer> GetAllPlayers();
        void AddPlayer(IPlayer player);
        void RemovePlayer(IPlayer player);
        void RemoveAllPlayers();
        void NotifyPlayer(PlayerState message, IPlayer player);
    }
}
