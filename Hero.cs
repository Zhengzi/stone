using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Hero
    {
        //dependency
        private Player player;

        //attribute
        private int health;
        private int attack;
        private int armor;
        private HeroPower heroPower;

        //control value
        private bool isAttacked;
        //private HeroClass hClass;

        public Hero(Player player)
        {
            this.player = player;
        }

    }
}
