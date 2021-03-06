﻿using System.Linq;

namespace Oppgave16
{
    class Model
    {
        //Lagrer ??
        public Spiller spiller;

        //Lagrer alle rom (romA, romB, romC) inni rom array
        public Rom[] rom;

        //Lagrer alle dør inni dører array
        public Dør[] dører;

        public Model()
        {
            //Lager spiller objekt
            spiller = new Spiller();

            //Lager navn, innhold, start, vunnet inni rom objekter
            var romA = new Rom { navn = "A", innhold = new[] { "rød nøkkel" }, start = true };
            var romB = new Rom { navn = "B", innhold = new[] { "grønn nøkkel" } };
            var romC = new Rom { navn = "C", innhold = new[] { "hvit nøkkel" } };
            var romD = new Rom { navn = "D", innhold = new[] { "blå nøkkel" } };
            var romE = new Rom { navn = "E", innhold = new[] { "grå nøkkel" } };
            var romF = new Rom { navn = "F", innhold = new string[0], vunnet = true };
            rom = new[] { romA, romB, romC, romD, romE, romF, };

            //henter lista med hvilken rom spiller har vært i
            //> henter den første eller defualt (ingenting eller null i dette tilfelle)
            spiller.rom = rom.FirstOrDefault(r => r.start);

            //Lagrer flere objekter av Dør inni dører
            dører = new[]
            {
                new Dør{ A= romB, B= romA, farge= "rød", åpen= false },
                new Dør{ A= romD, B= romA, farge= "grønn", åpen= false },
                new Dør{ A= romC, B= romB, farge= "grå", åpen= false },
                new Dør{ A= romE, B= romB, farge= "blå", åpen= false },
                new Dør{ A= romF, B= romE, farge= "hvit", åpen= false },
            };
        }


        public string doors()
        {
            //Henter hvilken rom spiller er i
            var rom = spiller.rom;

            //Where = En slags filter
            //Går igjennom dører liste > hvis dør.A og dør.B er lik rom, putter dette inn i dører i rommet.
            var dørerIRommet = dører.Where(d => d.A == rom || d.B == rom);

            //tom string
            var txt = "";

            //Går igjennom dørerIRommet variable
            foreach (var dør in dørerIRommet)
            {

                var til = dør.A == rom ? dør.B : dør.A;
                txt += dør.åpen
                    ? $"Gå til {til.navn}\n"
                    : $"Låse opp {dør.farge}\n";
            }
            return txt;
        }
    }
}