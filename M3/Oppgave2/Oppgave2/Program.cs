using System;

namespace Oppgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hvis isValid er lik false -> Start ShowHelpText()
            if (!IsValid(args)) 
            {
                ShowHelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;

            var lengthString = args[0];
            var options = args[1];

            foreach (var character in lengthString)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            foreach (var character in options)
            {
                if (character != 'l'
                    && character != 'L'
                    && character != 'd'
                    && character != 's')
                {
                    return false;
                }
            }

            return true;
        }

        private static void ShowHelpText()
        {

            Console.WriteLine("PasswordGenerator <length> <options>");
            Console.WriteLine(" Options:");
            Console.WriteLine(" - l = lower case letter");
            Console.WriteLine(" - L = upper case letter");
            Console.WriteLine(" - d = digit");
            Console.WriteLine(" - s = special character (!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}
