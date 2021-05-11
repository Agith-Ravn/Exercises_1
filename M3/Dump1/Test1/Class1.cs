using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump1
{
    class Class1
    {
        static void Something()
        {
            //To stroing
            //VS vil anta at variabel x uansett datatype
            var x = true; //bool
            string s = "" + x; //string
            double d = 99.123;

            string s2 = d.ToString("F");
        }

    }
}
