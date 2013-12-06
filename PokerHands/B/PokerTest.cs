using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Pokers;

[TestFixture]
public class PokerTest
{
    [Test]
    public void TestCompareHighCardAndWhiteWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(-1, poker.Compare(
            new string[] { "2H", "3D", "4S", "5C", "KD" },
            new string[] { "6C", "7H", "8S", "9C", "AH" }));
    }

    [Test]
    public void TestCompareHighCardAndBlackWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(1, poker.Compare(
            new string[] { "2H", "3D", "4S", "5C", "KD" },
            new string[] { "6C", "7H", "8S", "9C", "JH" }));
    }

    [Test]
    public void TestOnePairWinsHighHand()
    {
        Poker poker = new Poker();
        Assert.AreEqual(1, poker.Compare(
            new string[] { "2H", "2D", "4S", "5C", "3D" },
            new string[] { "6C", "7H", "8S", "9C", "JH" }));
    }

    [Test]
    public void TestOnePairWinsOnePairDueToLargePairNumber()
    {
        Poker poker = new Poker();
        Assert.AreEqual(-1, poker.Compare(
            new string[] { "2H", "2D", "4S", "5C", "3D" },
            new string[] { "7H", "7D", "4S", "5C", "3D" }));
    }

    [Test]
    public void TestOnePairWinsOnePairDueToLargerNonPairNumber()
    {
        Poker poker = new Poker();
        Assert.AreEqual(1, poker.Compare(
            new string[] { "7H", "7D", "8S", "5C", "3D" },
            new string[] { "7H", "7D", "4S", "5C", "3D" }));
    }


    [Test]
    public void TestIsHighHandHands()
    {
        var hands = new Hands(new string[] { "2H", "3D", "4S", "5C", "KD" });

        Assert.AreEqual(HandsType.HighHand, hands.HandsType);
    }

    [Test]
    public void TestIsOnePairHands()
    {
        var hands = new Hands(new string[] { "2H", "2D", "4S", "5C", "KD" });

        Assert.AreEqual(HandsType.OnePair, hands.HandsType);
    }

    // Enjoy!! :)
}