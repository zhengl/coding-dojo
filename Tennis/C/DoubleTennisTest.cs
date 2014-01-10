namespace Mars.UnitTests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    public class DoubleTennisTest
    {
        private Player server;
        private Player receiver;
        private Game game;

        [SetUp]
        public void SetupTennisTest()
        {
            this.server = new Player(new List<string> { "Wang", "CC" });
            this.receiver = new Player(new List<string> { "Jordon", "Sen" });
            this.game = new Game(this.server, this.receiver);
        }

        [Test]
        public void TestAdvantage()
        {
            this.server.SetPoint(4);
            this.receiver.SetPoint(3);
            Assert.AreEqual("advantage Wang and CC", this.game.Read());

            this.server.SetPoint(3);
            this.receiver.SetPoint(4);
            Assert.AreEqual("advantage Jordon and Sen", this.game.Read());

            this.server.SetPoint(5);
            this.receiver.SetPoint(4);
            Assert.AreEqual("advantage Wang and CC", this.game.Read());
        }

        [Test]
        public void TestWin()
        {
            this.server.SetPoint(4);
            this.receiver.SetPoint(2);
            Assert.AreEqual("Wang and CC win", this.game.Read());

            this.server.SetPoint(2);
            this.receiver.SetPoint(4);
            Assert.AreEqual("Jordon and Sen win", this.game.Read());

            this.server.SetPoint(5);
            this.receiver.SetPoint(3);
            Assert.AreEqual("Wang and CC win", this.game.Read());
        }
    }
}