using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_13_structure
{
    class Program
    {
        public static void Main()
        {
            Discounts saleDiscounts = new Discounts();

            saleDiscounts.Cloths = 10;
            saleDiscounts.HomeDecor = 5;
            saleDiscounts.Grocery = 2;

            Console.WriteLine(saleDiscounts.Cloths);
            Console.WriteLine(saleDiscounts.HomeDecor);
            Console.WriteLine(saleDiscounts.Grocery);
        }
    }

    public struct Discounts
    {
        public int CLoths { get; set; }
        public int HomeDecor { get; set; }
        public int Grocery { get; set; }
    }

}
