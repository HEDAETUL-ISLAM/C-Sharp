using System;

namespace Classes
{
    public class Person
    {
        public string name;

        public void Introduce(string to)
        {
            Console.WriteLine("hi  {0}, i am {1}", to, name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "bulbul";
            person.Introduce("ninad");
        }
    }
}