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
        Bowling bowlingGame;

        [SetUp]
        public void Setup()
        {
            bowlingGame = new Bowling();
        }

        [Test]
        public void TestOne()
        {
            Assert.True(true);
        }

        [Test]
        public void TestBowlingCube()
        {
            BowlingCube bowlingCube = new BowlingCube()
            {
                First = 8,
                Second = 2
            };

            Assert.IsNotNull(bowlingCube);
        }

        public void TestGetCubeScore()
        {
            BowlingCube firstBowlingCube = new BowlingCube()
            {
                First = 8,
                Second = 2
            };

            BowlingCube secondBowlingCube = new BowlingCube()
            {
                First = 7,
                Second = 2
            };

            int aCubeScore = bowlingGame.GetCubeScore(firstBowlingCube, secondBowlingCube, null);

            Assert.AreEqual(17, aCubeScore);
        }

        [Test]
        public void TestGetScore()
        {
            BowlingCube[] bowlingCubeArray = new BowlingCube[]
            {
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
                new BowlingCube(){First=10,Second=0},
            };

           var aBowling=new Bowling();

           int Result = aBowling.GetScore(bowlingCubeArray);

           Assert.AreEqual(300, Result);
        }


        [Test]
        public void TestGetScore2()
        {
            BowlingCube[] bowlingCubeArray = new BowlingCube[]
            {
                new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=5},
               new BowlingCube(){First=5,Second=0},
               new BowlingCube(){First=0,Second=0},
            };

            var aBowling = new Bowling();

            int Result = aBowling.GetScore(bowlingCubeArray);

            Assert.AreEqual(150, Result);
        }
    }
}
