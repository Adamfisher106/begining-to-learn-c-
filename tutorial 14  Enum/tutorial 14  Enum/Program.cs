using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_14__Enum
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Friday);
        }
    }

    enum WeekDays
    {
        Monday = 10,
        Teusday,
        Webnesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
