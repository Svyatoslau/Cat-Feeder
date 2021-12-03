using System;

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

        }
    }
}
