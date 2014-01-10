using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CodingDojoTemplate
{
    public class Player
    {
        public int point = 0;

        public IList<string> names = new List<string>();

        public string name
        {
            get
            {
                string fullName = string.Empty;
                for(int i = 0; i < names.Count; i ++) 
                {
                    if (i != names.Count - 1)
                    {
                        fullName += (names[i] + " and ");
                        continue;
                    }
                    else
                    {
                        fullName += names[i];
                    }
                }

                return fullName;
            }
        }

        public Player(string theName)
        {
            names.Add(theName);
        }

        public void AddPlayer(string theName)
        {
            names.Add(theName);
        }

        public void WinPoint(int num)
        {
            point = point + num;
        }
    }
}
