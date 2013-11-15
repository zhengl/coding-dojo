using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojoTemplate
{
    public class Game
    {
        private Player server;
        private Player receiver;
        public Game(Player theServer, Player theReceiver)
        {
            server = theServer;
            receiver = theReceiver;
        }

        private Dictionary<int, string> ScoreMap = new Dictionary<int, string> { 
            {0, "love"},
            {1,"fifteen"},
            {2,"thirty"},
            {3,"forty"}
        };

        public string Read()
        {
            if (IsGamePoint())
            {
                return "advantage " + server.point > rec
            }

            if (server.point >= 3 && receiver.point == server.point)
            {
                return "deuce";
            }

            if (server.point == receiver.point)
            {
                return ScoreMap[server.point] += " all";
            }
            else
            {
                return ScoreMap[server.point] += " " + ScoreMap[receiver.point];
            }
        }

        public bool IsGamePoint()
        {
            return server.point >= 3 && receiver.point >= 3
                && Math.Abs(server.point - receiver.point) == 1;
        }
    }
}
