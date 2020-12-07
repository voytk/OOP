using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();
            calendar["day"] = 15;
            calendar["month"] = 10;
            calendar["year"] = 20;
            Console.WriteLine(calendar.Calculate(10, 9, 20));
        }
    }
}
