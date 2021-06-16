using System;

namespace Oppgave17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Exception
             *  try - catch
             *  finally
             *  - NullReferenceException
             *  - DivideByZeroException
             *  - IndexOutOfRangeException
             *  - InvalidCastException
             *  - NotImplementedException
             *  Fange sepsifikk
             *  Fange alle
             *  Call stack
             *  Egne Exceptions
             */

            //ExceptionDemo1();
            //ExceptionDemo2();
            //ExceptionDemo3();
            //tryCatchDemo1();

            //Test
            try
            {
                validate(12);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            Console.WriteLine("Rest of the code");
        }

        // NullReferenceException
        private static void ExceptionDemo1()
        {
            string s = null;
            Console.WriteLine(s.Length);

            //  feilmelding:
            //  System.NullReferenceException: 'Object reference not set to an instance of an object.'
        }

        //IndexOutOfRangeException
        private static void ExceptionDemo2()
        {
            int[] a = new int[10];
            a[20] = 1;

            //  feilmelding:
            //  System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
        }

        //DivideByZeroException
        private static void ExceptionDemo3()
        {
            int i = 0;
            var number = 17 / i;

            //  feilmelding:
            //  System.DivideByZeroException: 'Attempted to divide by zero.'
        }


        private static void tryCatchDemo1()
        {
            try
            {
                //DivideByZeroException
                int i = 0;
                var number = 17 / i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Test");
        }

        static void validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry, Age must be greater than 18");
            }
        }
    }

    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {
        }
    }

}
