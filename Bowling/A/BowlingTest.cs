using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bowling.Tests
{
    [TestFixture]
    public class BlowingTest
    {
        private Bowling game;
        [SetUp]
        public void Setup()
        {
            game = new Bowling();
        }

        [Test]
        public void TestAllZero() 
        {
           var aInput = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
           int score = game.GetScore(aInput);
           Assert.AreEqual(0, score);
        }

        [Test]
        public void TestAllFull()
        {
            var aInput = new List<int> { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int score = game.GetScore(aInput);
            Assert.AreEqual(300, score);
        }

        [Test]
        public void Test21Throws()
        {
            var aInput = new List<int> { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};
            int score = game.GetScore(aInput);
            Assert.AreEqual(150, score);
        }

        [Test]
        public void Test20Throws()
        {
            var aInput = new List<int> { 10, 5, 5, 10, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int score = game.GetScore(aInput);
            Assert.AreEqual(165, score);
        }

        //[Test]
        //public void TestAllOne()
        //{
        //    int score = game.GetScore("1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1-1");
        //    Assert.AreEqual(10, score);
        //}
    }
}
