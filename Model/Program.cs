using System;
using System.Collections.Generic;
using Model.Ententity;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer devFeeder1 = new DispenserDeveloper();
            Developer devFeeder2 = new SensorDeveloper();

            Feeder feeder1 = devFeeder1.Create();
            Feeder feeder2 = devFeeder2.Create();


            //проверка работы гетеров и сеттеров в Timetable
            TumpleTimetable test1 = new TumpleTimetable(20, DateTime.Now);
            List<TumpleTimetable> test = new List<TumpleTimetable>();
            test.Add(test1);
            Timetable table = new Timetable("Ночная кормежка", test);

            Console.WriteLine($"Название расписания: {table.Name}");
            Console.WriteLine($"Вес корма: {table.Data[0].Weight}");
            Console.WriteLine($"Время создания расписания: {table.Data[0].Time}");
            
        }
    }
}
