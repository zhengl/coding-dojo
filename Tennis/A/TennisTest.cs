using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodingDojo
{
    [TestFixture]
    public class TennisTest
    {
        [Test]
        public void TestLoveAll()
        {
            Game game = new Game();
            Assert.AreEqual("love all", game.Read());
        }

        [Test]
        public void TestFifteenLove()
        {
            Game game = new Game();
            game.Goal(PlayerType.Server);
            Assert.AreEqual("fifteen love", game.Read());
        }

        [Test]
        public void TestFifteenAll()
        {
            Game game = new Game();
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Receiver);
            Assert.AreEqual("fifteen all", game.Read());
        }

        [Test]
        public void TestFifteenThirty()
        {
            Game game = new Game();
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Receiver);
            Assert.AreEqual("fifteen thirty", game.Read());
        }

        [Test]
        public void TestDeuce()
        {
            Game game = new Game();
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Receiver);
            Assert.AreEqual("deuce", game.Read());
        }

        [Test]
        public void TestDeuceTwice()
        {
            Game game = new Game();
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Receiver);
            game.Goal(PlayerType.Server);
            game.Goal(PlayerType.Receiver);
            Assert.AreEqual("deuce", game.Read());
        }

    }

}
