using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 25);
            Console.WriteLine(dt.ToString("dddd"));
            Console.ReadLine();
            //Результат: среда
        }
    }
}
