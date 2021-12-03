using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{

    
    abstract class Feeder
    {
        private string name; // Имя
        public string Name
        {
            get { return name; }
            set => name = value;
        }
        private int value; // Наполненность кормушки
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

       

        

        



        
    }
    class DispenserFeeder: Feeder
    {
        public DispenserFeeder()
        {
            Console.WriteLine("Кормушка с дозатором");
        }
    }

    class SensorFeeder: Feeder
    {
        public SensorFeeder()
        {
            Console.WriteLine("Кормушка с сенсором");
        }
    }

    abstract class Developer
    {   
        
        abstract public Feeder Create();
    }
    class SensorDeveloper : Developer
    {
        public override Feeder Create()
        {
            return new SensorFeeder();
        }
    }

    class DispenserDeveloper : Developer
    {
        public override Feeder Create()
        {
            return new DispenserFeeder();
        }
    }
}
