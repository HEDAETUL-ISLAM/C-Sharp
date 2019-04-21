using System;
using System.IO;

namespace Copy_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = "D:/my programs/C Sharp/hi.txt";
            var toFileName = "hi_copy.txt";    // copy file its name wise
            var toPath = "D:/my programs/hi_copy.txt"; // copy file in this location where its pointed

            var success = CopyFile(sourcePath, toPath);
            if (success)
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("sorry baby");
            }
        }


        public static bool CopyFile(string s, string d)
        {
            var success = false;
            try
            {
                File.Copy(s, d);
                success = true;
            }
            catch (Exception e)
            {
                success = false;
                Console.WriteLine(e.Message);
            }
            return success;
        }
    }
}
