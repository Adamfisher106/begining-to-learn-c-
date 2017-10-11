using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;

            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);

            var number = 2;
            var count = 10;
            var totalPrice = 20.95F;
            var character = 'A';
            var firstName = "Mosh";
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(count);
            Console.WriteLine(isWorking);
   
        }
    }
}
