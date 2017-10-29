using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_26_partialveiw
{
    public class ProgramBasicStaticClass
    {
        public static void Main()
        {
            Console.WriteLine(MyStaticClass.myStaticVariable);

            MyStaticClass.MyStaticMethod();

            MyStaticClass.MyStaticProperty = 100;

            Console.WriteLine(MyStaticClass.MyStaticProperty);
        }
    }

    public static class MyStaticClass
    {
        public static int myStaticVariable = 0;

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        public static int MyStaticProperty { get; set; }
    }
				
public class Program
    {
        public static void Main()
        {
            MyStaticClass.myStaticVariable = 100;

            MyStaticClass.MyStaticProperty = 200;

            MyStaticClass.myStaticVariable = 300;

            MyStaticClass.MyStaticProperty = 400;
        }
    }

    public static class MyStaticClassForShowingHowAStaticConstructorWorks
    {
        static MyStaticClassForShowingHowAStaticConstructorWorks()
        {
            Console.WriteLine("Inside static constructor.");
        }
        public static int myStaticVariable = 0;

        public static void myStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public static int MyStaticProperty { get; set; }

    }

    //you are able to use a static constructor inside of a non static class. it is done in a similar way.

    public class ProgramConstructorInANonStaticClass
    {
        public static void Main()
        {
            MyNonStaticClass mnsObj1 = new MyNonStaticClass();
            MyNonStaticClass mnsObj2 = new MyNonStaticClass();
            MyNonStaticClass mnsObj3 = new MyNonStaticClass();
        }
    }

    public class MyNonStaticClass
    {
        static MyNonStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }

        public void myNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }

}
