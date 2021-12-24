using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;

namespace Model1.Ententity
{
    public abstract class Developer
    {

        abstract public Feeder Create(string name, int value);
    }
}
