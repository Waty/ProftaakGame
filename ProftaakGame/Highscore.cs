using System;

namespace ProftaakGame
{
    public class Highscore
    {
        public Highscore(string name, int coins, int lives)
        {
            Name = name;
            Coins = coins;
            Lives = lives;
            Date = DateTime.Now;
        }

        public Highscore(int id, string name, DateTime date, int coins, int lives)
        {
            Id = id;
            Coins = coins;
            Lives = lives;
            Name = name;
            Date = date;
        }

        public int Id { get; private set; }
        public int Coins { get; private set; }
        public int Lives { get; private set; }
        public DateTime Date { get; private set; }

        public int Points
        {
            get { return Coins + Lives*100; }
        }

        public string Name { get; set; }
    }
}