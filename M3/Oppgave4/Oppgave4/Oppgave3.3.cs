using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave4
{
    class A
    {
        public static void Oppgave3_3()
        {
            bool? Sorted = null;
            int[] numbers1 = { 3, 4, 6, 4, 2, 5 };
            int[] numbers2 = { 3, 4, 6, 7, 9, 10 };

            Console.WriteLine("Oppgave 3.1:");
            Sorted = IsSorted(numbers1);
            foreach (var number in numbers1)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine(" is " + Sorted.ToString());

            Sorted = IsSorted(numbers2);
            foreach (var number in numbers2)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine(" is " + Sorted.ToString());
            Console.WriteLine();
        }

        private static bool IsSorted(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }

            return true;

        }
    }
}
