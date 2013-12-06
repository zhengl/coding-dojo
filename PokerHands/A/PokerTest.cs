using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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
    public void TestCompareOnePairAndBlackWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(1, poker.Compare(
            new string[] { "2H", "2D", "4S", "5C", "3D" },
            new string[] { "6C", "7H", "8S", "9C", "JH" }));
    }

    [Test]
    public void TestCompareOnePairAndWhiteWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(-1, poker.Compare(
            new string[] { "2H", "3D", "4S", "5C", "kD" },
            new string[] { "6C", "6H", "8S", "9C", "JH" }));
    }

    [Test]
    public void TestCompareBothOnePairAndWhiteWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(-1, poker.Compare(
            new string[] { "2H", "2D", "4S", "5C", "kD" },
            new string[] { "6C", "6H", "8S", "9C", "JH" }));
    }

    [Test]
    public void TestCompareBothTwoPairAndWhiteWins()
    {
        Poker poker = new Poker();
        Assert.AreEqual(-1, poker.Compare(
            new string[] { "JH", "JD", "5S", "4C", "kD" },
            new string[] { "6C", "6H", "8S", "8C", "JH" }));
    }

    // Enjoy!! :)
}