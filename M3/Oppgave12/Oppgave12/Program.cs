using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lager object av game class
            var game = new Game();

            while (true)
            {
                //Starter showInfo method + sender game object
                ShowInfo(game);

                //Mottar kommando fra deg, gjør om tekst til små bokstaver > inni i command variable
                var command = Ask("Kommando: ");

                //hvis command er lik exit > stop while loop
                if (command == "exit") break;

                //hvis command er lik "ny" > sjekk om game ikke er null, altså startet.
                //hvis den ikke er null > Gi opp > Lag nytt object (nytt spill) 
                if (command == "ny")
                {
                    if (game != null)
                    {
                        game.GiveUp();
                        Console.WriteLine("Trykk en tast for å fortsette");
                        Console.ReadKey();
                    }

                    game = new Game();
                    continue;
                }

                //TryParse = converterer + returnerer bool om string kan konverteres eller ikke
                var isNumber = int.TryParse(command, out int number);

                //Hvis isNumber er false > continue
                if (!isNumber) continue;

                //starter Guess method fra game object + sender number du skrev i console
                game.Guess(number);
            }
        }

        private static string Ask(string txt)
        {
            Console.Write(txt);
            return Console.ReadLine()?.ToLower();
        }

        //Console.clear - Fjerner alt fra console >
        //game.Show - 
        private static void ShowInfo(Game game)
        {
            Console.Clear();
            game.Show();
            Console.WriteLine("Kommandoer: \r\n - ny     = ny runde\r\n - <tall> = gjette\r\n - exit   = avslutte\r\n");
        }
    }
}
