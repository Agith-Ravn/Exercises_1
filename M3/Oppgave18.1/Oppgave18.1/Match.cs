using System;
using System.ComponentModel.Design;

namespace Oppgave18._1
{
    public class Match
    {
        private int _homeGoals;
        private int _awayGoals;
        private readonly string _bet;
        public bool IsRunning { get; private set; }

        public Match(string bet)
        {
            _bet = bet;
            IsRunning = true;
        }

        public void AddGoal(string command)
        {
            if (command == "H") _homeGoals++;
            else if (command == "B") _awayGoals++;
            else if (command == "X") Stop(command);
            else InvalidCommand();
        }

        public void InvalidCommand()
        {
            Console.WriteLine("Invalid command.. Try again");
            var command = Console.ReadLine();
            AddGoal(command);
        }

        public void GetScore()
        {
            Console.WriteLine($"\nStillingen er {_homeGoals}-{_awayGoals}.");
        }

        public string IsBetCorrect()
        {
            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            return _bet.Contains(result) ? "riktig" : "feil";
        }

        public void Stop(string command)
        {
            if (command == "X") IsRunning = false;
        }
    }
}