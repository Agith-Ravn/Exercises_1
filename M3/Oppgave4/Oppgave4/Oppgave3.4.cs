using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave4
{
    class B
    {

        const string Alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
        const string Cipher = "QWERTYUIOPÅÆØLKJHGFDSAZXCVBNM";

        public void Oppgave3_4()
        {                                 //????????????????
            var ciperText = EncryptChar("TERJE!");
            var plainText = DecryptChar(ciperText);

            Console.WriteLine(ciperText);
            Console.WriteLine(plainText);
        }

        public static char EncryptChar(char x)
        {
            return EncryptOrDecryptChar(x, Alfabet, Cipher);
        }

        public static char DecryptChar(char x)
        {
            return EncryptOrDecryptChar(x, Cipher, Alfabet);
        }


        public static char EncryptOrDecryptChar(char x, string from, string to)
        {
            if (!char.IsLetter(x)) return x;
            int index = from.IndexOf(x);
            return to[index];
        }
    }
}
