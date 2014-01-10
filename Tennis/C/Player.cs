namespace Mars
{
    using System.Collections.Generic;

    public class Player
    {
        public int point = 0;

        private ICollection<string> names;

        public string name
        {
            get
            {
                return string.Join(" and ", names);
            }
        }

        public int PlayerCount
        {
            get
            {
                return names.Count;
            }
        }

        public Player(string theName)
            : this(new List<string> { theName })
        {
        }

        public Player(ICollection<string> theNameList)
        {
            this.names = theNameList;
        }

        public void SetPoint(int num)
        {
            this.point = num;
        }

        public void WinPoint()
        {
            this.point++;
        }
    }
}
