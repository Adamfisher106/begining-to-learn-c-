using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_20_execeptions
{
    //Exception Handling in c#

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter Student Name: ");

            string studentName = Console.ReadLine();

            IList<string> studentList = FindAllStudentFromDatabase(studentName);

            Console.WriteLine("Total {0}: {1}", studentName, studentList.Count);


            Console.ReadKey();
        }

        public static IList<string> FindAllStudentFromDatabase(string studentName)
        {
            IList<string> studentList = null;

            // find all students with same name from the database 


            return studentList;
        }

    }

    //how to catch multiple
    public class Program2
    {
        public static void Main()
        {

            try
            {
                Console.Write("Please enter number: ");

                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter number: ");

                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                //LogError(ex);
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                //LogError(ex);
                Console.Write("Not a valid number. Please try again.");
            }
            catch (FormatException ex)
            {
                //LogError(ex);
                Console.Write("Not a valid number. Please try again.");
            }


            Console.ReadKey();

        }

    }

    //key words
    //----------------------------------------------------------------------------------------------------------------

    public class Program3
    {
        public static void Main()
        {
            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null. ");

            Console.WriteLine(std.StudentName);
        }
    }

    public class Student
    {

        public string StudentName { get; set; }
    }

    //Custom Exeptions
    //-----------------------------------------------------------------------------------------------------------------------------------

    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {

        }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }

    }

}
