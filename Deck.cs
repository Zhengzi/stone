using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class Deck
    {
        private List<Card> _cardList;
        private static Random rng = new Random();

        public List<Card> CardList
        {
            get { return _cardList; }
            set { _cardList = value; }
        }

        public void DisplayCardList()
        {
            for (int i = 0; i < CardList.Count; i++)
            {
                Console.WriteLine("Index " + i + ": " + CardList[i].CardName);
            }
        }

        private static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public void ShuffleCard()
        {
            Shuffle(CardList);
        }

        private bool IsEmpty()
        {
            return CardList.Count == 0;
        }

        public Card DrawCardFromDeck()
        {
            if (IsEmpty())
            {
                return null;
            }
            Card card = CardList[0];
            CardList.RemoveAt(0);
            return card;
        }

        public virtual bool isFull()
        {
            return CardList.Count >= 60;
        }

        public void AddCardIntoDeck(Card card)
        {
            if (isFull())
            {
                return;
            }
            CardList.Add(card);
        }
    }

    class HandDeck : Deck
    {
        public override bool isFull()
        {
            return CardList.Count >= 10;
        }
    }

    class CardDeck : Deck
    {
        public void LoadCardList(List<int> cardListInt)
        {
            CardList = new List<Card>();
            if (cardListInt.Count != 30)
            {
                Console.WriteLine("error");
                return;
            }
            foreach (var i in cardListInt)
            {
                Card c = CardUtil.LoadCardFromId(i);
                CardList.Add(c);
            }
            if (CardList.Count != 30)
            {
                Console.WriteLine("error");
                return;
            }
        }
    }
}
