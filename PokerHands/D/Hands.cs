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
            var sortedHandsDist = sortedHands.Select(x => x.GetValue()).Distinct().ToList();
            var cardTypeList = sortedHands.Select(x => x.CardType).Distinct().ToList();
            
            switch (sortedHandsDist.Count)
            {
                case 5:
                    var aIsStraight = this.IsStraight(sortedHands.Select(x => x.GetValue()).ToList());
                    var aCount = cardTypeList.Count;
                    if (aCount > 1)
                    {
                        if (aIsStraight)
                        {
                            return HandsType.Straight;
                        }
                        return HandsType.HighHand;
                    }
                    else
                    {
                        if (aIsStraight)
                        {
                            return HandsType.StraightFlush;
                        }
                        return HandsType.Flush;
                    }
                case 3:
                    foreach (var sortedHand in sortedHandsDist)
                    {
                        var aNum = sortedHands.Count(x => x.GetValue() == sortedHand);
                        if (aNum == 3)
                        {
                            return HandsType.ThreeOfAKind;
                        }

                        if (aNum == 2)
                        {
                            return HandsType.TwoPairs;
                        }
                    }

                    break;
                case 2:
                    foreach (var sortedHand in sortedHandsDist)
                    {
                        var aNum = sortedHands.Count(x => x.GetValue() == sortedHand);
                        if (aNum == 4 || aNum == 1)
                        {
                            return HandsType.FourOfAKind;
                        }

                        if (aNum == 3 || aNum == 2)
                        {
                            return HandsType.FullHouse;
                        }
                    }

                    break;

                case 4:
                    return HandsType.OnePair;
                    break;
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

        private bool IsStraight(List<int> aCards)
        {
            if ((aCards[4] - aCards[0]) == 4) return true;
            return false;
        }

    }
}
