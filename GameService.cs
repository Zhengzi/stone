using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class GameService
    {
        private static int _playedOrder;
        private Player player1;
        private Player player2;
        private bool isPlayer1Trun;
        private bool isP1Dead;
        private bool isP2Dead;
        private Random _random;
        private EventMgr eventMgr;

        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }

        public Player Player2
        {
            get { return player2; }
            set { player2 = value; }
        }

        public bool IsP1Dead
        {
            get { return isP1Dead; }
            set { isP1Dead = value; }
        }

        public bool IsP2Dead
        {
            get { return isP2Dead; }
            set { isP2Dead = value; }
        }

        public bool IsPlayer1Trun
        {
            get { return isPlayer1Trun; }
            set { isPlayer1Trun = value; }
        }

        public int GetPlayedOrder()
        {
            int order = _playedOrder;
            _playedOrder++;
            return order;
        }

        public void ResetPlayedOrder()
        {
            _playedOrder = 0;
        }

        public void GameStart()
        {
            Init();
            ChooseWhoFirst();
            DrawAndChangeCard();
            while (true)
            {
                var gameStatus = StartTurn(isPlayer1Trun ? player1 : player2);
                if (gameStatus == -1)
                {
                    break;
                }
                isPlayer1Trun = !isPlayer1Trun;
            }
            GameOver();
        }

        private void Init()
        {
            player1 = new Player(this);
            player2 = new Player(this);
            player1.Init();
            player2.Init();
            player1.EnemyPlayer = player2;
            player2.EnemyPlayer = player1;
            isP1Dead = false;
            isP2Dead = false;
            _random = new Random();
            eventMgr = new EventMgr();
            eventMgr.Init();
        }

        private void ChooseWhoFirst()
        {
            var flag = _random.Next(0, 2);
            isPlayer1Trun = flag == 1;
        }

        private void DrawAndChangeCard()
        {
            throw new NotImplementedException();
        }

        private void DrawCards(Player player, int numberCards)
        {
            for (int i = 0; i < numberCards; i++)
            {
                Card card = player.CardDeck.DrawCardFromDeck();
                player.HandDeck.AddCardIntoDeck(card);
                Event e = new DrawCardEvent(player);
                eventMgr.EventQueue.Enqueue(e);
                eventMgr.TriggerEvents();
            }            
        }

        private void TurnStart(Player player)
        {
            //set some param 
            //...

            //set event
            Event e = new TurnStartEvent(player);
            eventMgr.EventQueue.Enqueue(e);
            eventMgr.TriggerEvents();
        }

        private void TurnOver(Player player)
        {
            //set some param 
            //...

            //set event
            Event e = new TurnOverEvent(player);
            eventMgr.EventQueue.Enqueue(e);
            eventMgr.TriggerEvents();
        }

        private int StartTurn(Player player)
        {
            //pre start turn
            TurnStart(player);
            DrawCards(player, 1);

            //player's action
            while (true)
            {
                break;
            }

            //post turn event
            TurnOver(player);
            return 0;
        }

        private void GameOver()
        {
            Console.WriteLine("Game over");
            if (isP1Dead && isP2Dead)
            {
                Console.WriteLine("Draw!");
            }
            else if (isP1Dead)
            {
                Console.WriteLine("p2 win!");
            }
            else if (isP2Dead)
            {
                Console.WriteLine("p1 win!");
            }
            else
            {
                Console.WriteLine("Something Wrong happens!");
            }
        }

        public Player LoadPlayerProfile(PlayerProfile pp)
        {
            Player player = new Player(this);
            return player;
        }
    }
}
