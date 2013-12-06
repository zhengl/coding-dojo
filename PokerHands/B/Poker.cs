using Pokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Poker
{
    public int Compare(string[] black, string[] white)
    {
        return Compare(new Hands(black), new Hands(white));
    }

    public int Compare(Hands black, Hands white)
    {
        if (black.HandsType == white.HandsType)
        {
            if (black.HandsType == HandsType.OnePair)
            {
                if (black.GetOnePairValue() == white.GetOnePairValue())
                {
                    return black.GetOnePairSingleValue() > white.GetOnePairSingleValue() ? 1 : -1;
                }
                else
                {
                    return black.GetOnePairValue() > white.GetOnePairValue() ? 1 : -1;
                }
            }

            int blackHighestValue = black.GetHighestValue();
            int whiteHighestValue = white.GetHighestValue();

            return blackHighestValue.CompareTo(whiteHighestValue);
        }
        else
        {
            return black.HandsType > white.HandsType ? 1 : -1;
        }
    }
}