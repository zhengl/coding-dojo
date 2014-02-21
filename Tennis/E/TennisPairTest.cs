using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using CodingDojoTemplate;

namespace CodingDojoTemplate.Tests
{
    public class TennisPairTest
    {
        private Player server;
        private Player receiver;
        private Game game;

        [SetUp]
        public void SetupTennisTest()
        {
            server = new Player("Wang", "Drew");
            receiver = new Player("Jordon", "Michael");
            game = new Game(server, receiver);
        }

        [Test]
        public void TestLoveAll()
        {
            string score = game.Read();
            Assert.AreEqual("love all", game.Read());
        }

        [Test]
        public void TestFifteenLove()
        {
            server.WinPoint(1);
            Assert.AreEqual("fifteen love", game.Read());
        }

        [Test]
        public void TestFifteenAll()
        {
            server.WinPoint(1);
            receiver.WinPoint(1);
            Assert.AreEqual("fifteen all", game.Read());
        }

        [Test]
        public void TestFourtyFifteen()
        {
            server.WinPoint(3);
            receiver.WinPoint(1);
            Assert.AreEqual("forty fifteen", game.Read());
        }

        [Test]
        public void TestDeuceThree()
        {
            server.WinPoint(3);
            receiver.WinPoint(3);
            Assert.AreEqual("deuce", game.Read());
        }

        [Test]
        public void TestDeuceFour()
        {
            server.WinPoint(4);
            receiver.WinPoint(4);
            Assert.AreEqual("deuce", game.Read());
        }

        [Test]
        public void TestServerAdvantage()
        {
            server.WinPoint(4);
            receiver.WinPoint(3);
            Assert.AreEqual("advantage Wang and Drew", game.Read());
        }

        [Test]
        public void TestReceiverAdvantage()
        {
            server.WinPoint(3);
            receiver.WinPoint(4);
            Assert.AreEqual("advantage Jordon and Michael", game.Read());
        }

        [Test]
        public void TestServerWin()
        {
            server.WinPoint(5);
            receiver.WinPoint(3);
            Assert.AreEqual("Wang and Drew win", game.Read());
        }

        [Test]
        public void TestReceiverWin()
        {
            receiver.WinPoint(5);
            server.WinPoint(3);
            Assert.AreEqual("Jordon and Michael win", game.Read());
        }
    }
}