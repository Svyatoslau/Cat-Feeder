using System;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TumpleTimetable test = new TumpleTimetable(20, DateTime.Now);
            test.ShowDateTime();
        }
    }
}
