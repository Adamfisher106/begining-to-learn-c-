using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_10_ternary_operator
{
    class Program
    {
           public static void Main()
        {
            int x = 20, y = 10;

            var result = x > y ? "x is greater than y" : "x is less than or equal to y";

            Console.WriteLine(result);
        }
    }
}
