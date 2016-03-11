using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Event
    {

    }

    class MinionDeadEvent : Event
    {

    }

    class HeroAttackedEvent : Event
    {

    }

    class TurnStartEvent : Event
    {
        private Player player;

        public TurnStartEvent(Player player)
        {
            this.player = player;
        }
    }

    class TurnOverEvent : Event
    {
        private Player player;

        public TurnOverEvent(Player player)
        {
            this.player = player;
        }
    }


    class DrawCardEvent : Event
    {
        private Player player;

        public DrawCardEvent(Player player)
        {
            this.player = player;
        }
    }

    class MinionTakeDamage : Event
    {

    }

}
