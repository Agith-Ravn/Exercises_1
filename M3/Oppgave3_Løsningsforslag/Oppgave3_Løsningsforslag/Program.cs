using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ting
{
    class Program
    {
        //Hoved method som starter de andre methods
        static void Main(string[] args)
        {
            Exercise2_3();
            Exercise2_2();
            Exercise2_1();
        }


        private static void Exercise2_3()
        {
            /*
                #            #
                 ##        ## 
                  ###    ###
                   ########
                   ########
                  ###    ###
                 ##        ##
                #            # 
            */

            //Array (int)
            var iValues = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };

            //Looper igjennom iValues og putter inn i i -> Starter Row() + sender i verdi igjennom parameter
            // OBS! Row(i) kan virke forvirrende, men står uten { } for "enklere lesbarhet" 
            foreach (var i in iValues) Row(i);
        }


        private static void Row(int i)
        {
            //Starter andre funksjoner. Sender igjennom index value + en formel?
            Space(i);
            Hash(i + 1);
            Space(12 - i * 4);
            Hash(i + 1);
            NewLine();
        }


        private static void Exercise2_2()
        {
            /*
                  ##
                 ####
                ######
               ########
               ########
                ######
                 ####
                  ##
             */
            for (var i = 3; i >= 0; i--)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }

            NewLine();
        }
        private static void Exercise2_1()
        {
            /*
               ########
                ######
                 ####
                  ##
             */
            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }

            NewLine();
        }

        private static void Hash(int count)
        {
            for (var i = 0; i < count; i++) Hash();
        }

        private static void Hash()
        {
            Console.Write("#");
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static void Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }

        private static void Space()
        {
            Console.Write(" ");
        }
    }
}