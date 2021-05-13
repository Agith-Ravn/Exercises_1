using System;

namespace Oppgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Console.WriteLine(" ");
            Method2();
            Console.WriteLine(" ");
            Method3();


            //Du tegnet symbolene feil... 

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

        }


        //Tegning 1
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


        //Tegning 2
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


        //Tegning 3
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
                z = Z(i);

                Console.WriteLine(y + x + z + z + x + y);
            }
        }
            //Fill
            private static string X()
            {
                string x1 = "#";
                string x2 = null;
                x2 += x1;
                return x2;
            }

            //Whitespace1.1
            private static string Y()
            {
                string y1 = " ";
                string y2 = null;

                y2 += y1;
                return y2;
            }
            
            //Whitespace1.2
            private static string Z(int i)
            {
                int z1 = i * 2;
                int z4 = 6 - z1;
                string z2 = " ";
                string z3 = null;

                for (int j = 0; j < z4; j++)
            {
                z3 += z2;
            }
            return z3;
            }

    }
}
