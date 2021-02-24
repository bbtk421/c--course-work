using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>(); // private lists so it wont be null and not work
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); // this too
        
        public List<Player> Players { get { return _players; } set { _players = value; } } // add private varables
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // keeps track of players and thier bets

        public abstract void Play(); // no implimentation, send Play() to any class inheritting from Game

        public virtual void ListPlayers() // gets inheritted has implimentation but can be overridden
        {
        foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
