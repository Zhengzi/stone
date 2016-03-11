using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Minion : BroadCastObject
    {
        private int baseHealth;
        private int currentHealth;
        private int maxHealth;

        private int baseAttack;
        private int currentAttack;
        private int maxAttack;


        private Player player;


        private int frozen;
        private int silenced;
        private int corrupt;


        private bool isActive;
        private int spellDamageBonus;
        private int attackChance;
        private int windfury;
        private int charge;
        private int attackedInTurn;
        private int divineShield;
        private int battleCry;
        private int deathRattle;
        private int taunt;
        private int poisonous;
        private int combo;
        private int elusive;
        private int stealth;
        private int immune;
        private int inspire;
        private int joust;
        private int forgetful;
        private int enrage;



        public virtual void Dead()
        {

        }


    }
}
