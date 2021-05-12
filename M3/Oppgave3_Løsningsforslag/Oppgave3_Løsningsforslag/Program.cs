using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise2_3();
            Exercise2_2();
            //Exercise2_1();
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

            var iValues = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var i in iValues) Row(i);

            //for (var i = 0; i < 4; i++) Row(i);
            //for (var i = 4 - 1; i >= 0; i--) Row(i);
        }

        private static void Row(int i)
        {
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