using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_25_collections
{
    public class Programcollectionlists
    {
        public static void Main()
        {
            IList<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            Console.WriteLine(intList.Count);

            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            Console.WriteLine(strList.Count);

            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());

            Console.WriteLine(studentList.Count);


        }
    }
    public class Student
    {
    }


    public class Programaddingelements
    {
        public static void Main()
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(intList.Count);

            IList<Student2> studentList = new List<Student2>()
            {
                new Student2(){ StudentID=1, StudentName="Bill"},
                new Student2(){ StudentID=60, StudentName="Verionica"},
                new Student2(){ StudentID=2, StudentName= "The Holy Cod"},

            };

            Console.WriteLine(studentList.Count);
        }
    }
    public class Student2
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    public class programaddranges
    {
        public static void Main()
        {
            IList<int> intList1 = new List<int>();
            intList1.Add(10);
            intList1.Add(20);
            intList1.Add(30);
            intList1.Add(40);

            List<int> intList2 = new List<int>();

            intList2.AddRange(intList1);

            Console.WriteLine(intList2.Count);
        }
    }
    public class programaccessinglist
    {
        public static void Main()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);

            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

        }

    };

    public class Programaddelementintothelist
    {
        public static void Main()
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            intList.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var el in intList)
                Console.WriteLine(el);
        }
    }

    public class Programremovesanelementfromthelist
    {
        public static void Main()
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            intList.Remove(10); // removes 10 elements from a list

            intList.RemoveAt(2); //removes the 3rd element (index starts from 0)

            foreach (var el in intList)
                Console.WriteLine(el);
        }
    }
}

//sorted lists

//------------------------------------------------------------------------------------------------------------------
public class Programaddelementsintoasortedlist
{
    public static void Main()
    {
        SortedList<int, string> sortedList1 = new SortedList<int, string>();
        sortedList1.Add(3, "Three");
        sortedList1.Add(4, "Four");
        sortedList1.Add(1, "One");
        sortedList1.Add(5, "Five");
        sortedList1.Add(2, "Two");

        Console.WriteLine(sortedList1.Count);

        SortedList<string, int> sortedList2 = new SortedList<string, int>();
        sortedList2.Add("one", 1);
        sortedList2.Add("two", 2);
        sortedList2.Add("three", 3);
        sortedList2.Add("four", 4);
        // Compile time error: cannot convert from <null> to <int>
        // sortedList2.Add("Five", null);

        Console.WriteLine(sortedList2.Count);

        SortedList<double, int?> sortedList3 = new SortedList<double, int?>();
        sortedList3.Add(1.5, 100);
        sortedList3.Add(3.5, 200);
        sortedList3.Add(2.4, 300);
        sortedList3.Add(2.3, null);
        sortedList3.Add(1.1, null);

        Console.WriteLine(sortedList3.Count);
    }
}

public class Programgrabbingelements
{
    public static void Main()
    {
        SortedList<string, int> sortedList2 = new SortedList<string, int>();
        sortedList2.Add("one", 1);
        sortedList2.Add("two", 2);
        sortedList2.Add("three", 3);
        sortedList2.Add("four", 4);

        int val;

        if (sortedList2.TryGetValue("ten", out val))
            Console.WriteLine("value: {0}", val);
        else
            Console.WriteLine("Key is not valid.");

        if (sortedList2.TryGetValue("one", out val))
            Console.WriteLine("value: {0}", val);
    }
}

//dictionary 
//-------------------------------------------------------------------------------------

public class ProgramAddingelementsintoadiction__settingup
{
    public static void Main()
    {
        IDictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "One");
        dict.Add(2, "Two");
        dict.Add(3, "Three");

        Console.WriteLine(dict.Count);

    }
}

public class Programaccessingthedictionaryusingforereach
{
    public static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };

        foreach (KeyValuePair<int, string> item in dict)
        {
            Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
        }
    }
}


public class ProgramGettingAValue
{
    public static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };


        string result;

        if (dict.TryGetValue(4, out result))
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Could not find the specified key.");
        }
    }
}