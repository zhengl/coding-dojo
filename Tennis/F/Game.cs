using System;
using System.Collections.Generic;

namespace Tennis.Core
{
    public class Game
    {
        private Player server;
        private Player receiver;

        public const int DeucePoint = 3;

        public Game(Player theServer, Player theReceiver)
        {
            server = theServer;
            receiver = theReceiver;
        }

        private Dictionary<int, string> ScoreMap = new Dictionary<int, string>
        { 
            { 0, "love" },
            { 1, "fifteen" },
            { 2, "thirty" },
            { 3, "forty" }
        };

        public string Read()
        {
            if (IsGamePoint())
            {
                string serverName = server.Name1 + " and " + server.Name2;
                if (!string.IsNullOrEmpty(server.Name2) && server.Name2.Length != 0)
                {
                    return string.Format(
                        "advantage {0}",
                        server.point > receiver.point ? serverName : receiver.Name1 + " and " + receiver.Name2);
                }

                return string.Format(
                  "advantage {0}", server.point > receiver.point ? server.Name1 : receiver.Name1);
            }

            if (IsWinPoint())
            {
                string serverName = server.Name1 + " and " + server.Name2;
                if (!string.IsNullOrEmpty(server.Name2) && server.Name2.Length != 0)
                {
                    return string.Format(
                        "{0} win",
                        server.point > receiver.point ? serverName : receiver.Name1 + " and " + receiver.Name2);
                }
              
                    return string.Format(
                    "{0} wins", server.point > receiver.point ? server.Name1 : receiver.Name1);
            }

            if (server.point >= DeucePoint && receiver.point == server.point)
            {
                return "deuce";
            }

            if (server.point == receiver.point)
            {
                return ScoreMap[server.point] + " all";
            }
            else
            {
                return ScoreMap[server.point] += " " + ScoreMap[receiver.point];
            }
        }

        public bool IsGamePoint()
        {
            return server.point >= DeucePoint && receiver.point >= DeucePoint
                && Math.Abs(server.point - receiver.point) == 1;
        }

        public bool IsWinPoint()
        {
            if (Math.Abs(server.point - receiver.point) == 4)
            {
                return true;
            }

            return server.point >= DeucePoint && receiver.point >= DeucePoint
                && Math.Abs(server.point - receiver.point) == 2;
        }
    }
}
