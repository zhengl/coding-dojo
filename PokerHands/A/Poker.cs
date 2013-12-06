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
        int blackValue = black.GetValue();
        int whiteValue = white.GetValue();

        if (blackValue > whiteValue)
        {
            return 1;
        }
        else if (blackValue < whiteValue)
        {
            return -1;
        }

        return 0;
    }
}