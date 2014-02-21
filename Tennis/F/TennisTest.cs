using NUnit.Framework;
using Tennis.Core;

namespace Tennis.UnitTests
{
    public class TennisTest
    {
        private Player server;
        private Player receiver;
        private Game game;

        [SetUp]
        public void SetupTennisTest()
        {
            server = new Player("Wang");
            receiver = new Player("Jordon");
            game = new Game(server, receiver);
        }

        [Test]
        public void TestLoveAll()
        {
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
        public void TestDeuceFive()
        {
            server.WinPoint(5);
            receiver.WinPoint(5);
            Assert.AreEqual("deuce", game.Read());
        }

        [Test]
        public void TestAdvantage()
        {
            server.WinPoint(4);
            receiver.WinPoint(3);
            string result = string.Format("advantage {0}", server.Name1);
            Assert.AreEqual(result, game.Read());
        }

        [Test]
        public void TestWin()
        {
            server.WinPoint(5);
            receiver.WinPoint(3);
            string result = string.Format("{0} wins", server.Name1);
            Assert.AreEqual(result, game.Read());
        }

        [Test]
        public void TestWinfortyZero()
        {
            server.WinPoint(4);
            string result = string.Format("{0} wins", server.Name1);
            Assert.AreEqual(result, game.Read());
        }

        [Test]
        public void TestTwoPlayersWin()
        {
            server = new Player("Wang", "zhang");
            receiver = new Player("Jordon", "li");
            game = new Game(server, receiver);
            server.WinPoint(5);
            receiver.WinPoint(3);
            string result = string.Format("{0} win", server.Name1 + " and " + server.Name2);
            Assert.AreEqual(result, game.Read());
        }

        [Test]
        public void TestTwoPlayersAdvantage()
        {
            server = new Player("Wang", "zhang");
            receiver = new Player("Jordon", "li");
            game = new Game(server, receiver);
            server.WinPoint(4);
            receiver.WinPoint(3);
            string result = string.Format("advantage {0}", server.Name1 + " and " + server.Name2);
            Assert.AreEqual(result, game.Read());
        }
    }
}