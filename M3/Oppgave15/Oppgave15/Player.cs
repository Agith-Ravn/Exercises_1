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
            int player1Nr = 1;
            int player2Nr = 2;

            int winnerNr = random.Next(1, 3);

            points = player1Nr == winnerNr ? points += 1 : points -= 1;
            player2.points = player2Nr == winnerNr ? player2.points += 1 : player2.points -= 1;
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{playerName}: {points}");
        }
    }
}