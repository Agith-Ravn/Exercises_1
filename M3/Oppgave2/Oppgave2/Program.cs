using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {

        // static =
        // readonly =
        // Lager en ny random som skal bli gjenbrukt. "Random" med hvit skrift er variable?
        static readonly Random Random = new Random();

        //Main method
        //Main(string[] args) mottar string tekst og legges inn i array. 
        //args.Lenght = Betyr hvor mange argumenter det er er skrevet i command prompt Eksempel: Argument0 argument1 argument2
        static void Main(string[] args)
        {

            //Starter IsValid Method -> Hvis IsValid returnerer false -> ShowHelpText() method og stop
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }

            //konverterer argument 1 til int
            var length = Convert.ToInt32(args[0]);  //argument 1
            var options = args[1];            //argument 2

            //PadRight = Legger til char '1' på slutten av argument2. length bestemmer hvor mange som skal legges til.
            var pattern = options.PadRight(length, 'l');

            //Må deklarere en tom string, slik at det ikke kommer noen error
            var password = string.Empty;

            //MENS pattern.length (argument 2)er større enn null
            while (pattern.Length > 0)
            {
                // Mottar tilfeldig tall mellom 0 og pattern.Length - 1
                var randomIndex = Random.Next(0, pattern.Length - 1);
                
                //  
                var category = pattern[randomIndex];

                /* remove selected character
                   example:    01234567
                               abcdefgh
                               selected = d (randomIndex=3)
                               length = 8
                               we want "abc" + "efgh"                               
                 */

                pattern = pattern.Remove(randomIndex, 1);
                if (category == 'l') password += GetRandomLowerCaseLetter();
                else if (category == 'L') password += GetRandomUpperCaseLetter();
                else if (category == 'd') password += GetRandomDigit();
                else password += GetRandomSpecialCharacter();
            }
            Console.WriteLine(password);
        }

        private static char GetRandomSpecialCharacter()
        {
            const string allSpecialCharacters = "!\"#¤%&/(){}[]";
            var index = Random.Next(0, allSpecialCharacters.Length - 1);
            return allSpecialCharacters[index];
        }

        private static char GetRandomDigit()
        {
            return Random.Next(0, 9).ToString()[0];
        }

        private static char GetRandomUpperCaseLetter()
        {
            return GetRandomLetter('A', 'Z');
        }

        private static char GetRandomLowerCaseLetter()
        {
            return GetRandomLetter('a', 'z');
        }

        private static char GetRandomLetter(char min, char max)
        {
            return (char)Random.Next(min, max);
        }


        // IsValid mottar arguments du skriver på command prompt
        private static bool IsValid(string[] args)
        {
            // Hvis argument.Length ikke er lik 2, returner false
            if (args.Length != 2) return false;

            var lengthStr = args[0];
            var options = args[1];

            // Starter IsValdigPattern Method -> Sender igjennom argument 2 (index 1)
            // Hvis method returnerer false -> returner false
            if (!IsValidPattern(options)) return false;

            // Hvis method over returnerer true -> starter IsValidLength funksjon
            // Sender igjennom argument 1 (index 0)
            return IsValidLength(lengthStr);
        }


        // Method mottar argument 1 (index 0)
        private static bool IsValidLength(string lengthStr)
        {
            // Loop igjennom argument 1 
            foreach (var character in lengthStr)
            {
                // Hvis et av bokstavene i character iKKE er tall -> returner false 
                // Hvis ikke, altså inneholder tall -> returner true
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        //Mottar options (argument 2)
        private static bool IsValidPattern(string options)
        {
            //Looper igjennom argument 2 og sjekker hver char av string
            //Hvis character IKKE inneholder "lLds" -> returner false
            //Hvis character inneholder "lLds" -> returner true
            foreach (var character in options)
            {
                const string validCharacters = "lLds";
                if (!validCharacters.Contains(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator <length> <options>");
            Console.WriteLine("  Options:");
            Console.WriteLine("  - l = lower case letter");
            Console.WriteLine("  - L = upper case letter");
            Console.WriteLine("  - d = digit");
            Console.WriteLine("  - s = special character (!\"#¤%&/(){}[]");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("         Min. 1 lower case");
            Console.WriteLine("         Min. 1 upper case");
            Console.WriteLine("         Min. 2 special characters");
            Console.WriteLine("         Min. 2 digits");
        }
    }
}