using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class BroadCastObject : IComparable
    {
        private int playedOrder;

        public int PlayedOrder
        {
            get { return playedOrder; }
            set { playedOrder = value; }
        }

        public virtual void TriggerAction(Event triggerEvent)
        {

        }

        public int CompareTo(object obj)
        {
            BroadCastObject broadCastObject = (BroadCastObject)obj;
            if (PlayedOrder > broadCastObject.PlayedOrder)
                return 1;
            else if (PlayedOrder < broadCastObject.PlayedOrder)
                return -1;
            else return 0;
        }
    }
}
