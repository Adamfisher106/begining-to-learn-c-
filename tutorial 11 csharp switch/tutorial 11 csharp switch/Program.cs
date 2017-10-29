using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_11_csharp_switch
{
    class Program
    {
        int x = 10;

        switch (x)
            {
                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                   default:
                    Console.WriteLine("Unknown value");
                    break;
            }
    }
public class Program
{
    public static void Main()
    {
        string statementType = "switch";

        switch (statementType)
        {
            case "DecisionMaking":
                Console.Write(" is a decision making statement.");
                break;
            case "if.else":
                Console.Write("if-else");
                break;
            case "ternary":
                Console.Write("Ternary operator");
                break;
            case "switch":
                Console.Write("switch statement");
                goto case "DecisionMaking";
        }
    }
}
}
