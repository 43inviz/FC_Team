using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FC
{
    internal class Team : IEnumerable
    {
        public List<Player> PlayerList;

        public Team(List<Player> playerList)
        {
            PlayerList = playerList;
        }

       public IEnumerator GetEnumerator()
        {
            foreach(var player in PlayerList)
            {
                yield return player;
            }
        }
    }
}
