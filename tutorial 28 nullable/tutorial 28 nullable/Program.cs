using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_28_nullable

//a nullable strut that surches for the 
{
    public class Program
    {
        public static void Main()
        {
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");
        }// the else line is that i can use Console.WriteLine(i.getvalueordefault()); this will go and get a value in this case 0, because one has not been stated.
    }
    // shorthand int> i = null double? D=null.
    public class shorthand
    {
        public static void Main()
        {
            int? i = null;

            int j = i ?? 0;

            Console.WriteLine(j);
        }
    }
    // you are able to use a nullable type as a class. you can do this by writting class MyClass { public Nullable<int> i; } you then reference this in the test 
    // I am also able to use a nullable type comparision.
    public class Programnullcomparision
    {
        public static void Main()
        {
            int? i = null;
            int j = 10;


            if (i < j)
                Console.WriteLine("i < j");
            else if (i > 10)
                Console.WriteLine("i > j");
            else if (i == 10)
                Console.WriteLine("i == j");
            else
                Console.WriteLine("Could not compare");
        }
    }
    //
}
