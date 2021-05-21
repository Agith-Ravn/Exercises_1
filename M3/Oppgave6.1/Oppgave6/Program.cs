using System;

namespace Oppgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            
            var bet = Console.ReadLine();
            var match = new Match(bet);

            while (match.IsRunning)
            {
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                
                //Input kommando
                var command = Console.ReadLine();

                //Stoppe match, hvis du skriver X
                if (command == "X") match.Stop();

                //Hvis du skriver H > true > homeGoals++
                //Hvis du skriver B > false > awayGoals++
                if (command == "H") match.AddGoal(true);
                else if (command == "B") match.AddGoal(false);

                //Må bruker ${} med match.GetScore() inni. GetScore returnerer string
                Console.WriteLine($"Stillingen er {match.GetScore()}.");
            }

            //Sjekker om det du tippet inneholder i resultater -> sender true eller false
            string isBetCorrectText = match.IsBetCorrect() ? "riktig" : "feil";
            
            //Output tekst om hva du har tippet
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
