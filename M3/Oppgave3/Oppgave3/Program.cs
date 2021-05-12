using System;

namespace Oppgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method1();
            //Method2();
            Method3();

            //########
            //######
            //####
            //##

            //##
            //####
            //######
            //########
            //########
            //######
            //####
            //##

            //#            #
            // ##        ##
            //  ###    ###
            //   ########
            //   ########
            //  ###    ###
            // ##        ##
            //#            # 

            //= = = = = = = = = = =  =  = 
            //0 1 2 3 4 5 6 7 8 9 10 11 12
        }

        private static void Method1()
        {
            string x1 = "#";
            string x2 = null;
            int y1 = 8;
            int y2 = 2;

            for (int i = 0; i < 8; i++)
            {
                x2 += x1;
            }

            Console.WriteLine(x2);

            for (int i = 0; i < 3; i++)
            {
                y1 = y1 - y2;
                string x3 = x2.Substring(0, y1);
                Console.WriteLine(x3);
            }
        }

        private static void Method2()
        {
            string x1 = "#";
            string x2 = null;
            int y1 = 8;
            int y2 = 2;

            for (int i = 0; i < 4; i++)
            {
                x2 += x1 + x1;
                Console.WriteLine(x2);
            }
            Method1();
        }

        private static void Method3()
        {
            string x = null;
            string y = null;
            string z = null;

            for (int i = 0; i < 4; i++)
            {

                x += X();
                y += Y();
                if (i == 0)
                {
                    y = "";
                }

                z = Z();

                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);

            }
        }
        private static string X()
        {
            string x1 = "#";
            string x2 = null;
            x2 += x1;
            return x2;
        }

        private static string Y()
        {
            string y1 = "O";
            string y2 = null;

            y2 += y1;
            return y2;
        }

        private static string Z()
        {
            string z1 = "------";
            int z2 = 2;
            int z3 = z1.Length;
     
            z1 = z1.Substring(0, z3);
            z3 = z3 - z2;
            return z1;
        }

    }
}
