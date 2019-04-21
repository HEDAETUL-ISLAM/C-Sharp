using System;
using System.IO;

namespace File_System
{
    class Program
    {
        static void Main(string[] args)
        {
                var goodPath = "D:/my programs/C Sharp/hi.txt";
                var invalidPath = "D:/my programs/C Sharp\0/hi.txt";
                var wrongPath = "D:/my programs/java/0/hi.txt";

                //ReadTextFile(wrongPath);
                ReadAndHandelExcep(invalidPath);
        }
         public static void ReadTextFile(string path)
        {
            var text = File.ReadAllText(path);
            Console.Write(text);
        }
        public static void ReadAndHandelExcep(string path)
        {
            try
            {
                var text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
