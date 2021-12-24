using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;

namespace Model1.Ententity
{
    public class DispenserDeveloper : Developer
    {
        public override Feeder Create(string name, int value)
        {
            return new DispenserFeeder(name,value);
        }
    }
}
