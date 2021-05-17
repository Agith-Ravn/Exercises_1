using System;

namespace Oppgave3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing1();
            Drawing2();
            Drawing3();
        }


        private static void Drawing1()
        {
            /*
             * ########
             *  ######
             *   ####
             *    ##
             */

            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hashtag(8 - 2 * i);
                NewLine();
            }

            NewLine();
        }


        private static void Drawing2()
        {
            /*
             *    ##
             *   ####
             *  ######
             * ########
             * ########
             *  ######
             *   ####
             *    ##
             */


            for (int i = 3; i > 0; i--)
            {
                Space(i);
                Hashtag(8 - 2 * i);
                NewLine();
            }

            for (int i = 0; i < 4; i++)
            {
                Space(i);
                Hashtag(8 - 2 * i);
                NewLine();
            }

            NewLine();
        }


        private static void Drawing3()
        {

            /*
             *  #            #
             *   ##        ## 
             *    ###    ###
             *     ########
             *     ########
             *    ###    ###
             *   ##        ##
             *  #            # 
             */

            var iValues = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var i in iValues) Row(i);
        }

        private static void Row(int i)
        {
            Space(i);
            Hashtag(i + 1);
            Space(12 - i * 4);
            Hashtag(i + 1);
            NewLine();
        }


        private static void Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }
        private static void Space()
        {
            Console.Write(" ");
        }
        

        private static void Hashtag(int count)
        {
            for (var i = 0; i < count; i++) Hashtag();
        }
        private static void Hashtag()
        {
            Console.Write("#");
        }


        private static void NewLine()
        {
            Console.WriteLine();
        }

    }
}
