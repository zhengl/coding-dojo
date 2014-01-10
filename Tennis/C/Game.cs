namespace Mars
{
    using System;
    using System.Collections.Generic;

    public class Game
    {
        private Player server;
        private Player receiver;
        private Player lastWinnder;
        public Game(Player theServer, Player theReceiver)
        {
            this.server = theServer;
            this.receiver = theReceiver;
        }

        private Dictionary<int, string> ScoreMap = new Dictionary<int, string> { 
            {0, "love"},
            {1,"fifteen"},
            {2,"thirty"},
            {3,"forty"}
        };

        public string Read()
        {
            string winner = null;
            if (this.IsGameOver(out winner))
            {
                if (this.server.PlayerCount > 1)
                {
                    return string.Format("{0} win", winner); 
                }

                return string.Format("{0} wins", winner);
            }

            string advanager = null;
            if (this.IsAdvantage(out advanager))
            {
                return string.Format("advantage {0}", advanager);
            }

            if (IsDeuce())
            {
                return "deuce";
            }

            if (this.server.point == this.receiver.point)
            {
                return this.ScoreMap[this.server.point] += " all";
            }
            else
            {
                return string.Format("{0} {1}", this.ScoreMap[this.server.point], this.ScoreMap[this.receiver.point]);
            }
        }

        private bool IsGameOver(out string theWinnerName)
        {
            theWinnerName = null;
            if ((this.server.point > 3 || this.receiver.point > 3)
                && Math.Abs(this.server.point - this.receiver.point) > 1)
            {
                theWinnerName = (this.server.point > this.receiver.point) ? this.server.name : this.receiver.name;
                return true;
            }

            return false;
        }

        private bool IsAdvantage(out string theAdvantageName)
        {
            theAdvantageName = null;
            if (this.server.point >= 3 && this.receiver.point >= 3
                && Math.Abs(this.server.point - this.receiver.point) == 1)
            {
                theAdvantageName = (this.server.point > this.receiver.point) ? this.server.name : this.receiver.name;
                return true;
            }

            return false;
        }

        private bool IsDeuce()
        {
            return this.server.point >= 3 && this.receiver.point == this.server.point;
        }

        public void SetCurrentWinner(Player theCurrentWinner)
        {
            if (lastWinnder == theCurrentWinner)
            {
                theCurrentWinner.WinPoint();
            }

            lastWinnder = theCurrentWinner;
        }
    }
}
