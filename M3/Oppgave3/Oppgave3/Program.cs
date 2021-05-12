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
            string x1 = null;
            string y1 = null;

            for (int i = 0; i < 4; i++)
            {
                x1 += X(i);
                y1 += Y(0);

                Console.WriteLine(x1);
                Console.WriteLine(y1);

            }
        }

        private static string Y(int Index)
        {
            if (Index == 1)
            {
                return null;
            }

            string y1 = "-";
            string y2 = null;

            y2 += y1;
            return y2;
        }

        private static string X(int i)
        {
            string x1 = "#";
            string x2 = null;
            x2 += x1;
            return x2;
        }
    }
}
