using System;

namespace Oppgave15
{
    public class Player
    {
        private int points { get; set; }
        private string playerName { get; set; }

        public Player(string playerName, int points)
        {
            this.playerName = playerName;
            this.points = points;
        }

        public void Play(Player player2, Random random)
        {
            int playerOne = 1;
            int playerTwo = 2;

            int winner = random.Next(1, 3);

            points = playerOne == winner ? points++ : points--;
            player2.points = playerTwo == winner ? +1 : -1;

            Console.WriteLine(points);
            Console.WriteLine(player2.points);
        }

        public void ShowNameAndPoints()
        {
            throw new System.NotImplementedException();
        }
    }
}