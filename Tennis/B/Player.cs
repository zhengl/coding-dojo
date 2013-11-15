using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojoTemplate
{
    public class Player
    {
        public int point = 0;

        public string name;

        public Player(string theName)
        {
            name = theName;
        }

        public void WinPoint(int num)
        {
            point = point + num;
        }
    }
}
