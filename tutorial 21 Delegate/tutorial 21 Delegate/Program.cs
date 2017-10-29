using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_21_Delegate
{   //overview
    public class Program
    {
        public delegate void Print(int value);

        public static void Main()
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }

    //multi usage
    public class Program2
    {
        public delegate void Print(int value);

        public static void Main()
        {
            Print printDel = PrintNumber;
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(100000);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
