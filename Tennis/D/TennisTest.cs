using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingDojoTemplate;

namespace CodingDojoTemplate.Tests
{
    public class TennisTest
    {
        private Player server;
        private Player receiver;

        private Player server2;
        private Player receiver2;

        private Game game;

        private Game game2;

        [SetUp]
        public void SetupTennisTest()
        {
            server = new Player("Wang");
            receiver = new Player("Jordon");
            game = new Game(server, receiver);
        }

        [SetUp]
        public void SetupTennisTest2()
        {
            server2 = new Player("Wang");
            server2.AddPlayer("Wang1");
            receiver2 = new Player("Jordon");
            receiver2.AddPlayer("Jordon");
            game2 = new Game(server2, receiver2);
        }

        [Test]
        public void TestLoveAll00()
        {
            server.WinPoint(0);
            receiver.WinPoint(0);
            Assert.AreEqual("love all", game.Read());
        }

        [Test]
        public void TestFifteenLove10()
        {
            server.WinPoint(1);
            receiver.WinPoint(0);
            Assert.AreEqual("fifteen love", game.Read());
        }

        [Test]
        public void TestFifteenLove01()
        {
            server.WinPoint(0);
            receiver.WinPoint(1);
            Assert.AreEqual("love fifteen", game.Read());
        }

        [Test]
        public void TestFifteenAll11()
        {
            server.WinPoint(1);
            receiver.WinPoint(1);
            Assert.AreEqual("fifteen all", game.Read());
        }
        
        [Test]
        public void TestFourtyFifteen31()
        {
            server.WinPoint(3);
            receiver.WinPoint(1);
            Assert.AreEqual("forty fifteen", game.Read());
        }

        [Test]
        public void TestDeuceThree33()
        {
            server.WinPoint(3);
            receiver.WinPoint(3);
            Assert.AreEqual("deuce", game.Read());
        }
        
        [Test]
        public void TestDeuceFour44()
        {
            server.WinPoint(4);
            receiver.WinPoint(4);
            Assert.AreEqual("deuce", game.Read());
        }

        [Test]
        public void TestAdvantage43()
        {
            server.WinPoint(4);
            receiver.WinPoint(3);
            Assert.AreEqual("advantage Wang", game.Read());
        }

        [Test]
        public void TestAdvantage45()
        {
            server.WinPoint(4);
            receiver.WinPoint(5);
            Assert.AreEqual("advantage Jordon", game.Read());
        }

        [Test]
        public void TestWin53()
        {
            server.WinPoint(5);
            receiver.WinPoint(3);
            Assert.AreEqual("Wang wins", game.Read());
        }

        [Test]
        public void TestWin53_2()
        {
            server2.WinPoint(5);
            receiver2.WinPoint(3);
            Assert.AreEqual("Wang and Wang1 wins", game2.Read());
        }


        [Test]
        public void TestWin53_2()
        {
            server2.WinPoint(2);
            receiver2.WinPoint(0);
            Assert.AreEqual("Wang and Wang1 wins", game2.Read());
        }




    }
}