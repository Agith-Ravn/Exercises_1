using System;

namespace Oppgave10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oppgave - Lag disse tegnene:

            //########
            // ######
            //  ####
            //   ##

            //   ##
            //  ####
            // ######
            //########
            //########
            // ######
            //  ####
            //   ##

            //#            #
            // ##        ##
            //  ###    ###
            //   ########
            //   ########
            //  ###    ###
            // ##        ##
            //#            #

            Tegning1();
            Console.WriteLine();
            Tegning2();
            Console.WriteLine();
            Tegning3();
            Console.WriteLine();
        }

        private static void Tegning1()
        {
            int[] oppskrift = {3, 1, 1, 1, 1, 1, 1, 1, 1, 3, 2, 1, 1, 1, 1, 1, 1, 3, 2, 2, 1, 1, 1, 1, 3, 2, 2, 2, 1, 1, 3};
            LagTegning(oppskrift);
        }

        private static void Tegning2()
        {
            int[] oppskrift = {2, 2, 2, 1, 1, 3, 2, 2, 1, 1, 1, 1, 3, 2, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 3, 2, 1, 1, 1, 1, 1, 1, 3, 2, 2, 1, 1, 1, 1, 3, 2, 2, 2, 1, 1 };
            LagTegning(oppskrift);
        }

        private static void Tegning3()
        {
            string[] oppskrift =
            {
                "1.1", "2.12", "1.1", "3.1", "2.1", "1.2", "2.8", "1.2", "3.1", "2.2", "1.3", "2.4", "1.3", "3.1", "2.3", "1.8",
                "3.1", "1.8", "2.3", "3.1", "1.3", "2.4", "1.3", "2.2", "3.1", "1.2", "2.8", "1.2", "2.1", "3.1", "1.1", "2.12", "1.1"
                //Hvorfor fungerer ikke denne ^ raden? Samma det.. ikke så viktig. Laget på en tungt måte uansett..
            };
            LagTegning2(oppskrift);
        }

        public static void LagTegning(int[] oppskrift)
        {
            foreach (var x in oppskrift)
            {
                //1 = tegn
                //2 = mellomrom
                //3 = \n

                if (x == 1) Console.Write("#");
                if (x == 2) Console.Write(" ");
                if (x == 3) Console.Write("\n");
            }
        }

        public static void LagTegning2(string[] oppskrift)
        {
            for (int i = 0; i < oppskrift.Length; i++)
            {
                var test = oppskrift[i].Split('.');
                var action = Convert.ToInt32(test[0]);
                var multiply = Convert.ToInt32(test[1]);

                for (int j = 0; j < multiply; j++)
                {
                    if (action == 1) Console.Write("#");
                    if (action == 2) Console.Write(" ");
                    if (action == 3) Console.Write("\n");
                }
            }
        }
    }
}
