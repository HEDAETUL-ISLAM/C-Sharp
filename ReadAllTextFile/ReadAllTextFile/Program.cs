using System;
using System.IO;
using System.Text;

namespace ReadAllTextFile
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ascii = Encoding.ASCII;
            var utf8 = Encoding.UTF8;

            string englishFile = "D:/my programs/C Sharp/hi.txt";
            string banglaFile = "D:/my programs/C Sharp/bang.txt";

            ReadAllTypeFileExcp(englishFile, utf8);
            ReadAllTypeFileExcp(banglaFile, utf8);
        }
        public static void ReadAllTypeFileExcp(string path, Encoding en)
        {
            try
            {
                var text = File.ReadAllText(path, en);
                Console.WriteLine(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
