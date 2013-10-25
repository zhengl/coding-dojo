using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Bowling
    {
        public int GetScore(List<int> throws)
        {
            int totalScore = 0;
            int currentThrowIndex = 0;
            List<int> aGroupScore = new List<int>();
            for (int currRound = 0; currRound < 10; currRound++)
            {
                if (throws[currentThrowIndex] == 10)
                {
                    totalScore += throws[currentThrowIndex] + throws[currentThrowIndex + 1] + throws[currentThrowIndex + 2];
                    currentThrowIndex++;
                }
                else if (throws[currentThrowIndex] + throws[currentThrowIndex + 1] == 10)
                {
                    totalScore += throws[currentThrowIndex] + throws[currentThrowIndex + 1] + throws[currentThrowIndex + 2];
                    currentThrowIndex += 2;
                }
            }

            return totalScore;
        }
    }
}
