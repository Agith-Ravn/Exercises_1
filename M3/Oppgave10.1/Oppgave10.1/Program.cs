using System;
using System.Linq;

namespace Oppgave10._1
{
    class Program
    {

        static readonly Random random = new Random();
        
        static void Main(string[] args)
        {
            Console.WriteLine(PassordGeneratorInfo());
            string[] input = Console.ReadLine().Split(' ');

            ////Kun tii testing
            //for (int j = 0; j < input.Length; j++)
            //{
            //    Console.WriteLine(input[j]);
            //}

            //Hvis isValid returnerer false -> Stop
            if (!IsValid(input))
            {
                UgyldigInput();
                return; 
            }

            var passwordLength2 = Convert.ToInt32(input[0]);
            var passwordContent2 = input[1];

            string password = null;

            while (passwordContent2.Length > 0)
            {
                foreach (var character in passwordContent2)
                {
                    if (character == 'l')
                    {
                        password += GetRandomLowerCaseLetter();
                    }

                    if (character == 'L')
                    {
                        password += GetRandomUpperCaseLetter();
                    }

                    if (character == 'd')
                    {
                        password += RandomDigit();
                    }

                    if (character == 's')
                    {
                        password += GetRandomSpecialChar();
                    }



                }

               Console.WriteLine(password);
               break;
            }
        }

        public static string GetRandomSpecialChar()
        {
            const string chars = "!\"#¤%&/(){}[]";
            int index = random.Next(0, chars.Length);
            return chars[index].ToString();

        }

        private static string GetRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z').ToString(); ;
        }

        private static string GetRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z').ToString(); ;
        }

        static char GetRandomLetter(char min, char max)
        {
            return (char)random.Next(min, max);
        }

        private static string RandomDigit()
        {
            return random.Next(5, 15).ToString();
        }

        public static bool IsValid(string[] input)
        {
            if (input.Length != 2) return false;

            var passwordLength2 = input[0];
            var passwordContent2 = input[1];

            foreach (var character in passwordLength2)
            {
                if (!char.IsDigit(character)) return false;
            }

            foreach (var character in passwordContent2)
            {
                const string validCharacters = "lLds";
                if (!validCharacters.Contains(character)) return false;
                //if (character != 'l' || character != 'L' || character != 'd' || character != 's') return false;
            }

            return true;
        }

        private static string PassordGeneratorInfo()
        {
            string info = "PasswordGenerator \n  Options: \n  - l = lower case letter " +
                   "\n  - L = upper case letter \n  - d = digit \n  - s = special character(!\"#¤%&/(){}[]" +
                   "\nExample: PasswordGenerator 14 lLssdd \nMin. 1 lower case " +
                   "\nMin. 1 upper case \nMin. 2 special characters \nMin. 2 digits\n\n";
            
            return info;
        }

        private static void UgyldigInput()
        {
            Console.WriteLine("Ugylding kommando.. Prøv igjen:");
            Console.WriteLine(PassordGeneratorInfo());
        }
    }
}
