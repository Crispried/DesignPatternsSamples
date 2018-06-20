using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTest.Observer
{
    public interface IPlayer
    {
        void DoAction(PlayerState message);
    }
}
