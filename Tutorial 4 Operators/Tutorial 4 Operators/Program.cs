using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 3;

            Console.WriteLine((float)a / (float)b);
            Console.WriteLine((a + b) * c);


            //comparison opperators

            Console.WriteLine(a > b);
            // compariosns operate as a boolean.

            Console.WriteLine(!(a != b));
            Console.WriteLine(a = b);

            //logical opperators

            Console.WriteLine(c > b && c == a);
            // true and false makes it false.

            Console.WriteLine(!(c > b || c == a));
        }
    }
}
