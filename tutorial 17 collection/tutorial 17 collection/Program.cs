using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_17_collection
{
    //Adding in array elements
        
    public class Program1
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(1);
            arryList1.Add("Two");
            arryList1.Add(3);
            arryListy.Add(4.5);

            ArrayList.arryList2 = new ArrayList();
            arryList2.Add(100);
            arryList1.Add(200);

            //Add the entire Collection
            arryList1.AddRange(arryList2);

            for (int i = 0; i < arryList1.Count; i++)
                Console.WriteLine(arryList1[i]);
        }
    }

    //how to access an indevidual element
    public class Program2
    {
        public static void Main()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add(1);
            myArryList.Add("Two");
            myArryList.Add(3);
            myArryList.Add(4.5f);

            //Access individual item using indexer
            int firstElement = (int)myArryList[0];

            Console.WriteLine(firstElement);

            string secondElement = (string)myArryList[1];
            Console.WriteLine(secondElement);

            int thirdElement = (int)myArryList[2];
            Console.WriteLine(thirdElement);

            float fourthElement = (float)myArryList[3];
            Console.WriteLine(fourthElement);

            //use var keyword
            var firstElement2 = myArryList[0];
            Console.WriteLine(firstElement2);
        }
    }
    //ordering the code
    public class Program3
    {
        public static void Main()
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(300);
            arryList1.Add(200);
            arryList1.Add(100);
            arryList1.Add(500);
            arryList1.Add(400);

            Console.WriteLine("Original Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Reverse();

            Console.WriteLine("Reverse Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);

            arryList1.Sort();

            Console.WriteLine("Ascending Order:");

            foreach (var item in arryList1)
                Console.WriteLine(item);
        }
    }
    //hoow to tell with a program contains a certain element
    public class Program4
    {
        public static void Main()
        {
            ArrayList myArryList = new ArrayList();
            myArryList.Add(100);
            myArryList.Add("Hello World");
            myArryList.Add(300);

            Console.WriteLine(myArryList.Contains(100));
        }
    }

}
//SortedLists
//--------------------------------------------------------------------------------------------------------------------------

public class Program5
{
    public static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add("one", 1);
        sortedList.Add("two", 2);
        sortedList.Add("three", 3);
        sortedList.Add("four", "Four");

        int i = (int)sortedList["one"];
        int j = (int)sortedList["two"];
        int k = (int)sortedList["three"];
        string str = (string)sortedList["four"];

        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(str);
    }
}
// removing an elmement form a string
public class Program6
{
    public static void Main()
    {
        SortedList sortedList1 = new SortedList();
        sortedList1.Add("one", 1);
        sortedList1.Add("two", 2);
        sortedList1.Add("three", 3);
        sortedList1.Add("four", 4);

        sortedList1.Remove("one");//removes element whose key is 'one'
        sortedList1.RemoveAt(0);//removes element at zero index i.e first element: four

        foreach (DictionaryEntry kvp in sortedList1)
            Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
    }
}

//chekcing for an exisiting key in the corted list 
public class Program7
{
    public static void Main()
    {
        SortedList sList = new SortedList();
        sList.Add(3, "Three");
        sList.Add(2, "Two");
        sList.Add(4, "Four");
        sList.Add(1, "One");
        sList.Add(8, "Five");

        Console.WriteLine(sList.Contains(2)); // returns true
        Console.WriteLine(sList.Contains(4)); // returns true
        Console.WriteLine(sList.Contains(6)); // returns false

        Console.WriteLine(sList.ContainsKey(2)); // returns true
        Console.WriteLine(sList.ContainsKey(6)); // returns false

        Console.WriteLine(sList.ContainsValue("One")); // returns true
        Console.WriteLine(sList.ContainsValue("Ten")); // returns false
   

    }
}

// Stacks
//-----------------------------------------------------------------------------------------------------------
public class Program8
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push("Hello!!");
        myStack.Push(null);
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        foreach (var itm in myStack)
            Console.WriteLine(itm);
    }
}

//stack peek 

public class Program9
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        Console.WriteLine(myStack.Peek());
        Console.WriteLine(myStack.Peek());
        Console.WriteLine(myStack.Peek());

    }
}

//Stack Pop

public class Program10
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

        while (myStack.Count > 0)
            Console.WriteLine(myStack.Pop());

        Console.Write("Number of elements in Stack: {0}", myStack.Count);
    }
}

//Stack Contains
// this function looks for any of the id and returns if they are in hte stack

public class Program11
{
    public static void Main()
    {
        Stack myStack = new Stack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        Console.WriteLine(myStack.Contains(2));
        Console.WriteLine(myStack.Contains(10));
    }
}

//by adding the line myStack.Clear(); it will remove all of the elements.

//Stack Queue
//----------------------------------------------------------------------------------------------

//dequeue 
public class Program12
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(3);
        queue.Enqueue(2);
        queue.Enqueue(1);
        queue.Enqueue("Four");

        Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());

        Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);
    }
}

//Hashtable
//------------------------------------------------------------------------------------------------------------

//hashtable basic (add element)
public class Program13
{
    public static void Main()
    {
        Hashtable ht = new Hashtable()
                        {
                            { 1, "One" },
                            { 2, "Two" },
                            { 3, "Three" },
                            { 4, "Four" },
                            { 5, null },
                            { "Fv", "Five" },
                            { 8.5F, 8.5 }
                        };

        Console.WriteLine("Number of elements: {0}", ht.Count);

    }
}

//Accessing an element
public class Program14
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();

        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        ht.Add(4, "Four");
        ht.Add("Fv", "Five");
        ht.Add(8.5F, 8.5F);

        string strValue1 = (string)ht[2];
        string strValue2 = (string)ht["Fv"];
        float fValue = (float)ht[8.5F];

        Console.WriteLine(strValue1);
        Console.WriteLine(strValue2);
        Console.WriteLine(fValue);
    }
}
//  iterate output

public class Program15
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();

        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        ht.Add(4, "Four");
        ht.Add("Fv", "Five");
        ht.Add(8.5F, 8.5);

        foreach (DictionaryEntry item in ht)
            Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
    }
}
//ashTable are able to be used with keys and values and display them as such. 

public class Program16
{
    public static void Main()
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        ht.Add(4, "Four");
        ht.Add("Fv", "Five");
        ht.Add(8.5F, 8.5);

        foreach (var key in ht.Keys)
            Console.WriteLine("Key:{0}, Value:{1}", key, ht[key]);

        Console.WriteLine("***All Values***");

        foreach (var value in ht.Values)
            Console.WriteLine("Value:{0}", value);
    }
}
//to remove a speasific elements instead it is ht.Remove("Item that needs to be removed")


