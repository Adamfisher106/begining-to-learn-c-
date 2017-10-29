using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;


public class Program
{
    public static void Main()
    {
        int i = 10;

        bool result = i.IsGreaterThan(100);

        Console.WriteLine("Result: {0}", result);
    }
}

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
