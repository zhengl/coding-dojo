using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Hands
{
    private IEnumerable<Hand> hands;

    public Hands(string[] cards)
    {
        this.hands = cards.Select(card => new Hand(card));
    }

    public int GetHighestValue()
    {
        return this.hands.Max(hand => hand.GetValue());
    }

    public int GetValue()
    {
        int hv = GetHighestValue();
        int pv = 0;
        int pairCount = 0;
        var hs = hands.Select(x => x.GetValue()).OrderByDescending(x => x).ToArray();
        for (int i = 1; i < hs.Length; i++)
        {
            if (hs[i - 1] == hs[i])
            {
                pairCount++;
                pv = hs[i];
                break;
            }
        }

        pv *= 14;
        
        return pv + hv;
    }
}
