using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Player
    {
        private GameService gs;
        private Player enemyPlayer;

        private String playerName;

        private Hero hero;
        private CardDeck cardDeck;
        private HandDeck _handDeck;
        private int _manaCrystal;
        private int _availableManaCrystal;
        private BattleField battleField;
        private List<Secret> secrets;
        private Weapon weapon;

        private bool isHeroPowerUsed;
        private int overload;

        public Player(GameService gs)
        {

        }

        public void Init()
        {
            this.battleField = new BattleField(this);
            _manaCrystal = 0;
            _availableManaCrystal = 0;
            _handDeck = new HandDeck();
            cardDeck = new CardDeck();
            //this.hero = new Hero(this);
        }


        public Player EnemyPlayer
        {
            get { return enemyPlayer; }
            set { enemyPlayer = value; }
        }

        public HandDeck HandDeck
        {
            get { return _handDeck; }
            set { _handDeck = value; }
        }

        public CardDeck CardDeck
        {
            get { return cardDeck; }
            set { cardDeck = value; }
        }
    }
}
