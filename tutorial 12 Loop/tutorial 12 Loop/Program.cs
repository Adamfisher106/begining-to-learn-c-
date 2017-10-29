using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_12_Loop
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }
    }

    class program
    {
        public static void Main()
        {
            for (;;)
            {
                Console.Write(1);
            }
        }
    }

    public class DOWhileLoop
    {
        public static void Main()
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;
            } while (i < 10); // this statement controlls the loop and prevents it form going over 9.
        }
    }

}
