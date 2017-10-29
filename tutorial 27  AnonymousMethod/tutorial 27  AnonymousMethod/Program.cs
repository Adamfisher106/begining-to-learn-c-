using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_27__AnonymousMethod
{
    public class ProgramBasicAM
    {
        public delegate void Print(int value);

        public static void Main()
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }


}
