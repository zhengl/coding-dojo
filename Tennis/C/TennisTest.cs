namespace Mars.UnitTests
{
    using NUnit.Framework;

    public class TennisTest
    {
        private Player server;
        private Player receiver;
        private Game game;

        [SetUp]
        public void SetupTennisTest()
        {
            this.server = new Player("Wang");
            this.receiver = new Player("Jordon");
            this.game = new Game(this.server, this.receiver);
        }

        [Test]
        public void TestAll()
        {
            Assert.AreEqual("love all", this.game.Read());

            server.SetPoint(1);
            receiver.SetPoint(1);
            Assert.AreEqual("fifteen all", this.game.Read());

            server.SetPoint(2);
            receiver.SetPoint(2);
            Assert.AreEqual("thirty all", this.game.Read());
        }

        [Test]
        public void TestNotAllBelowThree()
        {
            server.SetPoint(1);
            receiver.SetPoint(0);
            Assert.AreEqual("fifteen love", this.game.Read());

            server.SetPoint(0);
            receiver.SetPoint(1);
            Assert.AreEqual("love fifteen", this.game.Read());

            server.SetPoint(3);
            receiver.SetPoint(1);
            Assert.AreEqual("forty fifteen", this.game.Read());
        }

        [Test]
        public void TestDeuce()
        {
            this.server.SetPoint(3);
            this.receiver.SetPoint(3);
            Assert.AreEqual("deuce", this.game.Read());

            this.server.SetPoint(4);
            this.receiver.SetPoint(4);
            Assert.AreEqual("deuce", this.game.Read());
        }

        [Test]
        public void TestAdvantage()
        {
            this.server.SetPoint(4);
            this.receiver.SetPoint(3);
            Assert.AreEqual("advantage Wang", this.game.Read());

            this.server.SetPoint(3);
            this.receiver.SetPoint(4);
            Assert.AreEqual("advantage Jordon", this.game.Read());

            this.server.SetPoint(5);
            this.receiver.SetPoint(4);
            Assert.AreEqual("advantage Wang", this.game.Read());
        }

        [Test]
        public void TestWin()
        {
            this.server.SetPoint(4);
            this.receiver.SetPoint(2);
            Assert.AreEqual("Wang wins", this.game.Read());

            this.server.SetPoint(2);
            this.receiver.SetPoint(4);
            Assert.AreEqual("Jordon wins", this.game.Read());

            this.server.SetPoint(5);
            this.receiver.SetPoint(3);
            Assert.AreEqual("Wang wins", this.game.Read());
        }

        [Test]
        public void TestSetWinner()
        {
            game.SetCurrentWinner(server);
            game.SetCurrentWinner(server);
            Assert.AreEqual(1, server.point);

            game.SetCurrentWinner(receiver);
            game.SetCurrentWinner(server);
            Assert.AreEqual(1, server.point);
            Assert.AreEqual(0, receiver.point);

            game.SetCurrentWinner(receiver);
            game.SetCurrentWinner(receiver);
            Assert.AreEqual(1, receiver.point);
        }
    }
}