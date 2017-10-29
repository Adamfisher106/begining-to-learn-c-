using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_31_action_func
{
    public class Programfuncaction
    {
        public static void Main()
        {
            Action<int> printActionDel = delegate (int i)
            {
                Console.WriteLine(i);
            };

            printActionDel(10);
        }
    }
}
