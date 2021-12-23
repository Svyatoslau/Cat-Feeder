using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;

namespace Model1.Ententity
{
    class SensorDeveloper : Developer
    {
        public override Feeder Create()
        {
            return new SensorFeeder();
        }
    }
}
