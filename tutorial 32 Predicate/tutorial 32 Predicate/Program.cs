using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_32_Predicate
{

    public class Programpredicatedelgate
    {
        public static void Main()
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);
        }

        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
