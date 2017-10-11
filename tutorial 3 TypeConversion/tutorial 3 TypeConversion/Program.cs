using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_3_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);


            try
                {
                    var number = "1234";
                    int x = Convert.ToInt32(number);
                    Console.WriteLine(x);
                }
                catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("The String could not be converted");
            }
        }
    }
}
