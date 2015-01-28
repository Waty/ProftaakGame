using System;
using System.Collections.Generic;

namespace ProftaakGame
{
    public class Highscore
    {
        private static readonly List<Highscore> Highscores = new List<Highscore>();

        public Highscore(int coins, int lives)
        {
            Coins = coins;
            Lives = lives;
            Time = DateTime.Now;
        }

        public Highscore(DateTime date, int coins, int lives)
        {
            Coins = coins;
            Lives = lives;
            Time = date;
        }

        public int Coins { get; set; }
        public int Lives { get; set; }
        public DateTime Time { get; set; }

        public int Points
        {
            get { return Coins*Lives; }
        }

        public static void Add(Highscore highscore)
        {
            Highscores.Add(highscore);
        }
    }
}