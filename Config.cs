using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Config
    {

    }

    public enum CardSet
    {
        Basic,
        Classic,
        GoblinsVsGnomesGrand,
        Tournament,
        Naxxramas,
        BlackrockMountain,
        Promotion
    };

    public enum CardTypes
    {
        Spell,
        Weapon,
        //Secret,
        Minion
    };

    public enum MinionType
    {
        Beast,
        Demon,
        Dragon,
        Mech,
        Murloc,
        Pirate,
        Totem,
        General
    };

    public enum SpellType
    {
        Secret,
        General
    }

    public enum CardRarity
    {
        Free,
        Common,
        Rare,
        Epic,
        Legendary,
        //Golden
    };

    public enum CardClass
    {
        Druid, Hunter, Mage, Paladin, Priest, Rogue, Shaman, Warlock, Warrior, Neutral
    };
}
