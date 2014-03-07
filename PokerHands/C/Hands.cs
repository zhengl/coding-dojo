using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pokers;

namespace Pokers
{
    public class Hands
    {
        private IEnumerable<Hand> hands;

        public HandsType HandsType
        {
            get
            {
                return GetHandsType();
            }
        }

        public Hands(string[] cards)
        {
            this.hands = cards.Select(card => new Hand(card));
        }

        public int GetHighestValue()
        {
            return this.hands.Max(hand => hand.GetValue());
        }

        private HandsType GetHandsType()
        {
            var sortedHands = hands.OrderBy(hand => hand.GetValue()).ToList();
            for (int i = 1; i < sortedHands.Count; i++)
            {
                if (sortedHands[i - 1].GetValue() == sortedHands[i].GetValue())
                {
                    return HandsType.OnePair;
                }
            }

            return Pokers.HandsType.HighHand;
        }

        public int GetOnePairValue()
        {
            if (this.HandsType != Pokers.HandsType.OnePair)
            {
                return 0;
            }

            var sortedHands = hands.OrderBy(hand => hand.GetValue()).ToList();
            for (int i = 1; i < sortedHands.Count; i++)
            {
                if (sortedHands[i - 1].GetValue() == sortedHands[i].GetValue())
                {
                    return sortedHands[i - 1].GetValue();
                }
            }

            return 0;
        }

        public int GetOnePairSingleValue()
        {
            if (this.HandsType != Pokers.HandsType.OnePair)
            {
                return 0;
            }

            var pairValue = GetOnePairValue();
            return hands.Where(hand => hand.GetValue() != pairValue)
                .OrderByDescending(hand => hand.GetValue()).ElementAt(0).GetValue();
        }

    }
}
