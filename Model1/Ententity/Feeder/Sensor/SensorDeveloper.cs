using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;

namespace Model1.Ententity
{
    public class SensorDeveloper : Developer
    {
        public override Feeder Create(string name, int value)
        {
            return new SensorFeeder(name, value);
        }
    }
}
