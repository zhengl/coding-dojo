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
            

            if (IsWin())
            {
                return GetVantageName() + getWinName();; // + server.point > rec
            }

            if (isAdvantage())
            {
                return "advantage " + GetVantageName(); // + server.point > rec
            }

            if (IsDuce())
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

        private string getWinName()
        {
            return server.names.Count > 1 ? " wins" : " win";
        }

        public bool IsDuce()
        {
           return server.point >= 3 && receiver.point == server.point;
        }

        public bool isAdvantage()
        {
            return (server.point > 3 || receiver.point > 3) && Math.Abs(server.point - receiver.point) >= 1;
        }

        public string GetVantageName()
        {
            return server.point > receiver.point ? server.name : receiver.name;
        }

        public bool IsWin()
        {
            return (server.point > 3 || receiver.point > 3) && Math.Abs(server.point - receiver.point) >= 2;
        }
    }
}
