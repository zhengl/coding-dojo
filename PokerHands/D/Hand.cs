using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokers
{
    public class Hand
    {
        private static readonly Dictionary<string, CardType> CardTypesMap = new Dictionary<string, CardType> { 
            {"H",CardType.Heart},
            {"D", CardType.Diamond},
            {"S", CardType.Spade},
            {"C",CardType.Club}
        };

        private string card;
        public CardType CardType { get; private set; }

        private static string[] MAPPINGS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Hand(string card)
        {
            this.card = card;
            var cardTypeString = card[1].ToString();
            CardType = CardTypesMap[cardTypeString];
        }

        public int GetValue()
        {
            string valueStr = this.card[0].ToString();
            return Array.IndexOf(MAPPINGS, valueStr);
        }

    }
}
