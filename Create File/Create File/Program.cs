using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Create_File
{
    class Program
    {
        public static void Main(string[] args)
        {
            var utf8 = Encoding.UTF8;
            var optionPath = "D:/my programs/C Sharp/hi.txt";
            var writeToPath = "D:/my programs/C Sharp/Create File/hi_new.txt";

            //var text = ReadAllTextInFile(optionPath, utf8);
            //CreateFileFromText(writeToPath, text);

            var lines = ReadAllLinesInFile(optionPath);
            CreatedFileFromLines(writeToPath, lines, utf8);
        }

        public static void CreatedFileFromLines(string path, List<string> lines, Encoding en = null)
        {
            var finalText = string.Empty;
            foreach(var line in lines)
            {
                finalText += $"{line}\n";
            }
            CreateFileFromText(path, finalText, en);
        }
        public static void CreateFileFromText(string path, string text, Encoding en = null)
        {
            if(en == null)
            {
                en = Encoding.UTF8;
            }
            var bytes = en.GetBytes(text);
            var byteCount = en.GetByteCount(text);
            using (FileStream fileStream =File.Create(path))
            {
                fileStream.Write(bytes, 0, byteCount);
            }
        }
        public static List<string> ReadAllLinesInFile(string path)
        {
            var lines = new string[] { };
            try
            {
                var now = DateTime.Now;
                lines = File.ReadAllLines(path);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines.ToList();
        }
        public static string ReadAllTextInFile(string path , Encoding en)
        {
            var text = string.Empty;
            try
            {
                text = File.ReadAllText(path, en);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return text;
        }
    }
}
