using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Hand
{
    private string card;
    private static string[] MAPPINGS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    public Hand(string card)
    {
        this.card = card;
    }

    public int GetValue()
    {
        string valueStr = this.card[0].ToString();
        return Array.IndexOf(MAPPINGS, valueStr) + 2;
    }
}

