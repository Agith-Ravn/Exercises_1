using System;

namespace Oppgave15
{
    /* - Skal være 3 spilere
     * - hver spiller har et navn og har 10 poeng hver.
     * - Velger 2 tilfeldige spillere som skal spille mot hverandre
     * - Når play() method blir kjørt, skal det velges 1 tilfeldig vinner og taper.
     * - vinneren får 1+, taperen mister 1-
     */

    /* - Program - Game - Player
     *  
     */

    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var players = new[] { new Player("Per", 10), new Player("Pål", 10), new Player("Espen", 10) };
            
            //For loop (kjører loop 10x)
            for (var round = 1; round <= 10; round++)
            {
                var playerIndex1 = random.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + random.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];

                // Tilfeldig player object
                // > Kjører method som er inni object
                // + tar med tilfeldig player 2 object 
                player1.Play(player2, random);
            }

            foreach (var player in players)
            {
                player.ShowNameAndPoints();
            }


        }
    }
}
