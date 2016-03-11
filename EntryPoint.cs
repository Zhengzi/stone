using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_HearthStone
{
    class EntryPoint
    {
        private static int Main(string[] args)
        {
            Test();
            Console.ReadLine();
            return 0;
        }

        public static void Test()
        {
            Util u = new Util();
            PlayerProfile pp = u.CreatePlayerProfile1();
            CardDeck cd = new CardDeck();
            cd.LoadCardList(pp.CardList);
            cd.ShuffleCard();
            cd.DisplayCardList();
        }
    }
}
