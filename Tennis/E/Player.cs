using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojoTemplate
{
    public class Player
    {
        public string Name { get; private set; }

        public int Point { get; private set; }

        public bool IsPair { get; private set; }

        public Player(string theName)
        {
            Name = theName;
            IsPair = false;
        }

        public Player(string theTm1, string theTm2)
        {
            Name = string.Format("{0} and {1}", theTm1, theTm2);
            IsPair = true;
        }

        public void WinPoint(int num)
        {
            Point = Point + num;
        }
    }
}
