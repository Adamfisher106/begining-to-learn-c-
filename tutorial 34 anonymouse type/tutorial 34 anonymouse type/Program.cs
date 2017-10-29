using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_34_anonymouse_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };

            Console.WriteLine(myAnonymousType.GetType().ToString());

        }
    }
}
