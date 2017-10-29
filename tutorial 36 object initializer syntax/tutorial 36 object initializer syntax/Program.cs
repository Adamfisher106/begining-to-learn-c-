using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_36_object_initializer_syntax
{

    public class Student2
    {
        public int StudentID2 { get; set; }
        public string StudentName2 { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student2 std = new Student2()
            {
                StudentID2 = 1,
                StudentName2 = "Bill",
                Age = 20,
                Address = "New York"
            };
        }
    }//using a collection initializer syntax


    public class Programcollectioninitializersyntax
    {
        public static void Main()
        {
            var student1 = new Student() { StudentID = 1, StudentName = "John" };
            var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
            var student3 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

            IList<Student> studentList = new List<Student>() {
                                                    student1,
                                                    student2,
                                                    student3,
                                                    student4,
                                                    student5
                                                };

            Console.WriteLine("Total Students: {0}", studentList.Count);
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

    }
}
