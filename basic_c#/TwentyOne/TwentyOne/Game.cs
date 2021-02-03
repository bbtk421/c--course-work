using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

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
