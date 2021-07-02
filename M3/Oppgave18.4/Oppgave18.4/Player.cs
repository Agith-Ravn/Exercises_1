using System;
using System.Reflection.Metadata.Ecma335;

namespace Oppgave18._4
{
    public class Player
    {
        private string Name { get; set; }
        private int Points { get; set; }
        private Random random = new Random();

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public void Play(Player player2)
        {
            var player = 1;
            var nextPlayer = 2;
            var winnerNumber = random.Next(1,2);
            if (winnerNumber == player)
            {
                Points += 1;
                player2.Points -= 1;
            }
            else
            {
                Points -= 1;
                player2.Points += 1;
            }
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Navn: {Name} - Poeng {Points}");
        }

    }
}