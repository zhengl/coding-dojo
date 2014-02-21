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
                if (server.Point > receiver.Point)
                {
                    return "advantage " + server.Name;
                }
                else
                {
                    return "advantage " + receiver.Name;
                }
            }

            if (server.Point >= 3 && receiver.Point == server.Point)
            {
                return "deuce";
            }

            if (server.Point == receiver.Point)
            {
                return ScoreMap[server.Point] + " all";
            }
            else
            {
                if (server.Point - receiver.Point >= 2 && receiver.Point >= 3)
                {
                    return server.Name + " " + GetWinStr(server.IsPair);
                }
                else if (receiver.Point - server.Point >= 2 && server.Point >= 3)
                {
                    return receiver.Name + " " + GetWinStr(receiver.IsPair);
                }
                else
                {
                    return ScoreMap[server.Point] + " " + ScoreMap[receiver.Point];
                }
            }
        }

        private string GetWinStr(bool theIsPair)
        {
            return theIsPair ? "win" : "wins";
        }

        public bool IsGamePoint()
        {
            return server.Point >= 3 && receiver.Point >= 3
                && Math.Abs(server.Point - receiver.Point) == 1;
        }
    }
}
