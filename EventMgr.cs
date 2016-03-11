using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class EventMgr
    {
        private Queue<Event> eventQueue;
        private List<Minion> minionList;

        public Queue<Event> EventQueue
        {
            get { return eventQueue; }
            set { eventQueue = value; }
        }

        public List<Minion> MinionList
        {
            get { return minionList; }
            set { minionList = value; }
        }

        public void Init()
        {
            EventQueue = new Queue<Event>();
            MinionList = new List<Minion>();
        }

        private void InvokeEvents()
        {
            List<BroadCastObject> broadCastList = GetBroadCastList();
            while (eventQueue.Count != 0)
            {
                Event triggerEvent = eventQueue.Dequeue();
                foreach (var broadCastObject in broadCastList)
                {                    
                    broadCastObject.TriggerAction(triggerEvent);
                }
            }
        }

        private void InvokeMinionDead()
        {
            MinionList.Sort();
            while (MinionList.Count != 0)
            {
                Minion minion = MinionList[0];
                MinionList.RemoveAt(0);
                //bf remove;
                minion.Dead();
                //add an event
                InvokeEvents();
            }
        }

        public void TriggerEvents()
        {
            InvokeEvents();
            InvokeMinionDead();
        }

        public List<BroadCastObject> GetBroadCastList()
        {
            //fake
            List<BroadCastObject> broadCastList = new List<BroadCastObject>();
            broadCastList.Sort();
            return broadCastList;
        }  
    }


    class PlayerProfile
    {
        private String playerName;
        private CardClass cClass;
        private List<int> cardList;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public CardClass CClass
        {
            get { return cClass; }
            set { cClass = value; }
        }

        public List<int> CardList
        {
            get { return cardList; }
            set { cardList = value; }
        }
    }

    class Util
    {
        #region test
        public PlayerProfile CreatePlayerProfile1()
        {
            PlayerProfile pp = new PlayerProfile();
            pp.PlayerName = "xzz";
            pp.CClass = CardClass.Warrior;
            pp.CardList = new List<int>()
            {
                109009,109009,9003,9003,9009,9009,109001,109001,
                109002,109002,109005,109005,9004,9004,109006,109006,
                9008,9008,209000,209000,100002,100002,400007,400007,
                400006,109013,109013,9007,200018,200018
            };
            return pp;
        }
        public PlayerProfile CreatePlayerProfile2()
        {
            PlayerProfile pp = new PlayerProfile();
            pp.PlayerName = "wht";
            pp.CClass = CardClass.Hunter;
            pp.CardList = new List<int>()
            {
                0, 1, 2
            };
            return pp;
        }
        #endregion
    }
}
