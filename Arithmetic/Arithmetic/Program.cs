using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(String[] arg)
        {
            int result;
            int x = 10, y = 5;

            result = x + y;
            Console.WriteLine("sum is : " + result);

            result = x - y;
            Console.WriteLine("sub is : " + result);

            result = x * y;
            Console.WriteLine("mul is : " + result);

            result = x / y;
            Console.WriteLine("div is : " + result);
        }
    }
}