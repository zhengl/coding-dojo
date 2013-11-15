using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo
{
    public class Game
    {
        private int serverPoints, receiverPoints = 0;
        public string Read()
        {
            string preStr = string.Empty;
            string tailStr = string.Empty;

            if (serverPoints == receiverPoints && serverPoints == 3)
            {
                return "deuce";
            }

            if (serverPoints == receiverPoints)
            {
                tailStr = "all";
                return GetScore(serverPoints) +" " + tailStr;
            }
            if (serverPoints != receiverPoints)
            {
                return GetScore(serverPoints) + " " + GetScore(receiverPoints);
            }
            return string.Empty;
        }

        public void Goal(PlayerType type)
        {
            switch (type)
            { 
                case PlayerType.Server:
                    if (receiverPoints == 4 && serverPoints == 3)
                    {
                        receiverPoints = 3;
                    }
                    else
                    {
                        serverPoints++;
                    }
                    break;
                case PlayerType.Receiver:
                    if (receiverPoints == 3 && serverPoints == 4)
                    {
                        serverPoints = 3;
                    }
                    else
                    {
                        receiverPoints++;
                    }
                    break;
                default:break;
            }
        }

        private string GetScore(int i)
        {
            switch (i)
            {
                case 0:
                    return "love";
                case 1:
                    return "fifteen";
                case 2:
                    return "thirty";
                case 3:
                    return "forty";
                default:
                    return string.Empty;
            }
                     
        }
    }

    public enum PlayerType
    {
        Server,
        Receiver
    }
}
