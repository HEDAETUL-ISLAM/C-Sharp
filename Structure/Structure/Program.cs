using System;

namespace Structure
{
    public struct Address
    {
        public string city;
        public string state;
    }
    struct Person
    {
        public string name;
        public int age;

        public Address a1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;

            p1.name = "Hedaetul";
            p1.age = 23;

            p1.a1.city = "Kurigram";
            p1.a1.state = "Dhaka";



            Console.WriteLine("So result is");
            Console.WriteLine("name : " + p1.name);
            Console.WriteLine("age : " + p1.age);
            Console.WriteLine("city : " + p1.a1.city);
            Console.WriteLine("state : " + p1.a1.state);
        }
    }
}