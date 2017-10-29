using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_16_C_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] intArray1 = new int[5];
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] intArray3 = { 1, 2, 3, 4, 5 };
        }
    }

    public class Program2
    {
        public static void Main()
        {
            string[] strArray1, strArray2;

            strArray1 = new string[5]{ "1st Element",
                                   "2nd Element",
                                   "3rd Element",
                                   "4th Element",
                                   "5th Element"
                                  };



            strArray2 = new string[]{ "1st Element",
                                   "2nd Element",
                                   "3rd Element",
                                   "4th Element",
                                   "5th Element"
                                  };

            Console.WriteLine(strArray1.Length);
            Console.WriteLine(strArray2.Length);
        }
    }

    public class Program3
    {
        public static void Main()
        {
            Array array = Array.CreateInstance(typeof(int), new int[1] { 5 }, new int[1] { 1 });

            array.SetValue(1, 1);
            array.SetValue(2, 2);
            array.SetValue(3, 3);
            array.SetValue(4, 4);
            array.SetValue(5, 5);

            for (int i = 1; i <= array.Length; i++)
                Console.WriteLine("Array value {0} at position {1}", array.GetValue(i), i);
        }
    }

					//multi-Dimentional Array
    public class Program4
    {
        public static void Main()
        {
            int[,] intArray = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(intArray[0, 0]);

            Console.WriteLine(intArray[0, 1]);

            Console.WriteLine(intArray[1, 0]);

            Console.WriteLine(intArray[1, 1]);

            Console.WriteLine(intArray[2, 0]);

            Console.WriteLine(intArray[2, 1]);
        }
    }
    // Jagged Array


    public class Program5
    {
        public static void Main()
        {
            int[][] intJaggedArray = new int[2][];

            intJaggedArray[0] = new int[3] { 1, 2, 3 };

            intJaggedArray[1] = new int[2] { 4, 5 };

            Console.WriteLine(intJaggedArray[0][0]);

            Console.WriteLine(intJaggedArray[0][2]);

            Console.WriteLine(intJaggedArray[1][1]);
        }
    }
    //Jagged Multi dimentional Array

    public class Program6
    {
        public static void Main()
        {
            int[][,] intJaggedArray = new int[3][,];

            intJaggedArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            intJaggedArray[1] = new int[2, 2] { { 3, 4 }, { 5, 6 } };
            intJaggedArray[2] = new int[2, 2];

            Console.WriteLine(intJaggedArray[0][1, 1]);

            Console.WriteLine(intJaggedArray[1][1, 0]);

            Console.WriteLine(intJaggedArray[1][1, 1]);
        }
    }

}