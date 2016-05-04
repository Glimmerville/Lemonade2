using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeClas
{
    class Player //note: I should reference the player by name at some point since I collect it.
    {
        public string playerName { get; set; }
        private double playerCash;
        public double cash { get; set; } = 5;


        //Constructor
        public Player(string name, double cash)
        {
            this.playerName = name;
            this.playerCash = cash;
        }
    }
}

