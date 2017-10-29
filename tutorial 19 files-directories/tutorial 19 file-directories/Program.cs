using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_19_Stream_io
{
    class Program
    {
        public static void Main()
        {
            string dummyLines = "This is first line." + Environment.NewLine +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

            //Opens DummyFile.txt and append lines. If file is not exists then create and open.
            File.AppendAllLines(@"C:\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
        }
        
    }
    public class Program2
    {
        public static void Main()
        {

            //Opens DummyFile.txt and append Text. If file is not exists then create and open.
            File.AppendAllText(@"C:\ DummyFile.txt", "This is File testing");


            //Opens DummyFile.txt and write texts. If file is not exists then create and open.
            File.WriteAllText(@"C:\DummyFile.txt", "This is dummy text");

            //Check whether file is exists or not at particular location
            bool isFileExists = File.Exists(@"C:\ DummyFile.txt"); // returns false

            //Copy DummyFile.txt as new file DummyFileNew.txt
            File.Copy(@"C:\DummyFile.txt", @"D:\NewDummyFile.txt");

            //Get when the file was accessed last time 
            DateTime lastAccessTime = File.GetLastAccessTime(@"C:\DummyFile.txt");

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(@"C:\DummyFile.txt");

            // Move file to new location
            File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

            //Open file and returns FileStream for reading bytes from the file
            FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);

            //Open file and return StreamReader for reading string from the file
            StreamReader sr = File.OpenText(@"D:\DummyFile.txt");

            //Delete file
            File.Delete(@"C:\DummyFile.txt");

        }
    }
}
