using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_9_if_else_condition
{
    public class Program
    {
        public static void Main()
        {
            if(true)
            {
                Console.WriteLine("This will be displayed");
            }

            if(false)
            {
                Console.WriteLine("This will not be displayed");
            }
        }
    }
    public class Program2
    {
        public static void Main()
        {
            int i = 10, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
        }
    }
    public class Program3
    {
        public static void Main()
        {
            int i = 10;

            if (i > 0)
            {
                if (i <= 100)
                {
                    Console.WriteLine("i is positive number less than 100");
                }
                else
                {
                    Console.WriteLine("i is positive number greater than 100");
                }

            }
        }
    }
}
