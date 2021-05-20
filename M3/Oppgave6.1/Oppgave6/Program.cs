using System;

namespace Oppgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output tekst (Info om tipping)
            Console.Write("Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");

            //Input går til bet
            var bet = Console.ReadLine();

            //Start verdier
            var homeGoals = 0;
            var awayGoals = 0;
            var matchIsRunning = true;

            //Mens matchIsRunning er true
            while (matchIsRunning)
            {
                //Output tekst (Info om kommandoer)
                Console.Write("Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
                
                //Input kommando
                var command = Console.ReadLine();

                //????
                matchIsRunning = command != "X";

                //Hvis input kommando er lik H -> homeGoals får +1
                if (command == "H") homeGoals++;

                //Hvis IKKE input kommando er lik B -> awayGoals får +1
                else if (command == "B") awayGoals++;

                //
                Console.WriteLine($"Stillingen er {homeGoals}-{awayGoals}.");
            }

            /* Nested ternary Operator = a ? b : c ? d : e
             * a ? b : (c ? d : e)
             * Hvis a er true = b
             * hvis a er false -> sjekk c ? d : e -> hvis c er true = d
             *                                       hvisc er false = e
             *                                       
             * Hvis homeGoals er lik awayGoals = "U"
             * Hvis homeGoals IKKE er lik awayGoals -> sjekk om homeGoals er større enn awayGoals = "H"
             *                                             hvis homeGoals er mindre enn awayGoals = "B"
             */
            var result = homeGoals == awayGoals ? "U" : homeGoals > awayGoals ? "H" : "B";

            //Sjekker om det du tippet inneholder i resultater -> sender true eller false
            var isBetCorrect = bet.Contains(result);

            //Hvis isBetCorrect er true = riktig, hvis ikke = feil
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";

            //Output tekst om hva du har tippet
            Console.WriteLine($"Du tippet {isBetCorrectText}");
        }
    }
}
