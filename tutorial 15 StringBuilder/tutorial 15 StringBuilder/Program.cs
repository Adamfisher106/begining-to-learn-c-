using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Program
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder("Hello ", 50);

            sb.Append("world!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line");

            Console.WriteLine(sb);
        }
    }

    public class Program2
    {
        public static void Main()
        {
            StringBuilder amountMsg = new StringBuilder("Your total amount  is ");

            amountMsg.AppendFormat("{0:C} ", 25);

            Console.WriteLine(amountMsg);
        }
    }

    public class program3
    {
        public static void Main()
        {
        StringBuilder sb = new StringBuilder("Hello World!!");

        string str = sb.ToString();

        Console.WriteLine(str);
            
        }
    }
