using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Bowling
    {
        const int round = 10;
        public int GetCubeScore(BowlingCube firstCube, BowlingCube second, BowlingCube third)
        {
            int aResult = firstCube.First + firstCube.Second;
            if (firstCube.First == 10)
            {
                if (second.First == 10)
                {
                    aResult = aResult + second.First + third.First;
                }
                else
                {
                    aResult = aResult + second.First +second.Second;
                }
            }
            else
            {
                if (aResult == 10)
                {
                    aResult = aResult + second.First;
                }
            }

            return aResult;
        }

        public int GetScore(BowlingCube[] theCubes)
        {
            if (theCubes.Count() != round + 2)
            {
                throw new Exception("invalid input");
            }

            int aResult = 0;
            for (var i = 0; i < round; i++)
            {
                aResult += GetCubeScore(theCubes[i], theCubes[i + 1], theCubes[i + 2]);
            }

            return aResult;
        }
    }

    public class BowlingCube
    {
        public int First { get; set; }

        public int Second { get; set; }
    }
}
