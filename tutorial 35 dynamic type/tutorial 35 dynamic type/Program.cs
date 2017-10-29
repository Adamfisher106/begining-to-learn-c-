using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_35_dynamic_type
{

    public class Programinitalatttempt
    {
        public static void Main()
        {
            dynamic dynamicStudent = new Student();

            dynamicStudent.FakeMethod();
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }

        public void DisplayStudentDetail()
        {
            Console.WriteLine("Name: {0}", this.StudentName);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Standard: {0}", this.StandardID);
        }
    }

    class Programdatatransfer
    {
        static void PrintValue(dynamic val)
        {
            Console.WriteLine(val);
        }

        static void Main(string[] args)
        {

            PrintValue("Hello World!!");
            PrintValue(100);
            PrintValue(100.50);
            PrintValue(true);
            PrintValue(DateTime.Now);
        }
    }
}
