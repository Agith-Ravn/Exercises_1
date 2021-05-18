using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oppgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kaller getWords Method + lagrer retur verdi
            var words = GetWords();

            //Henter tilfeldig index
            var randomWordIndex = new Random().Next(words.Length);

            //Henter et tilfeldig ord med index ^
            var selectedWord = words[randomWordIndex];
            
            Console.WriteLine("Valgt ord: "selectedWord);


            for (int i = 0; i < words.Length; i++)
            {
                if (i % 1000 == 0) Console.Write(".");
                
                //Is last part off first word equal to first part of second word?
                if (X(selectedWord, words[i]))
                {
                    //(\n = new line)
                    Console.WriteLine("\n" + words[i]);
                    return;
                }
            }
        }

        private static bool X(string selectedWord, string word)
        {
            throw new NotImplementedException();
        }

        static string[] GetWords()
        {
            //Henter tekstfil
            string textFile = @"C:\Users\Visjon\Documents\GitHub\GET_Academy\M3\Oppgave5\Oppgave5\ordliste.txt";
             
            //Til senere bruk. (lagring av siste ord som du ble valgt)
            var lastWord = string.Empty;

            //Til senere bruk (lagring av alle ord som har vært valgt)
            var wordList = new List<string>();

            foreach (var line in File.ReadLines(textFile, Encoding.UTF8))
            {
                //Splitter string ved \t (tabulator space)
                var parts = line.Split('\t');

                //Henter første ordet
                var word = parts[1];
                
                //Hvis første ordet IKKE er lik lastWord og ord ikke inneholder -
                //Legg til i wordList 
                if (word != lastWord && !word.Contains("-")) wordList.Add(word);

                //lagrer siste ord
                lastWord = word;
            }

            //returnerer liste 
            return wordList.ToArray();

        }
    }
}
