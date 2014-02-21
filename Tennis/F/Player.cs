namespace Tennis.Core
{
    public class Player
    {
        public int point = 0;

        public string Name1 { get; set; }

        public string Name2 { get; set; }

        public Player(string theName)
        {
            Name1 = theName;
        }

        public Player(string name1, string name2)
        {
            Name1 = name1;
            Name2 = name2;
        }

        public void WinPoint(int num)
        {
            point = point + num;
        }

    }
}
