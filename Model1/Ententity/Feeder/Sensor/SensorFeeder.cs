﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;

namespace Model1.Ententity
{
    class SensorFeeder : Feeder
    {
        public SensorFeeder(string name, int value)
        {
            Value = value;
            Name = name;
            Type = "Sensor";
        }
    }
}
