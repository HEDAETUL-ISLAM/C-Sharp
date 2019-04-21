using System;
using System.IO;

namespace Write_Text
{
    class Program
    {
        public static void Main(string[] args)
        {
            var path = "D:/my programs/C Sharp/Write Text/new.txt";
            var writeTo = "D:/my programs/C Sharp/Write Text/afterNew.txt";
        

            var text = ReadAllText(path);
            //File.WriteAllText(writeTo, text);  // write one time 

            File.AppendAllText(writeTo,text);
        } 
        
        public static string ReadAllText(string path)    // write same line but many times
        {
            var text = string.Empty;
            try
            {
                text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return text;
        }
    }
}
