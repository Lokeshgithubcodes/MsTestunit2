using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestproject2
{
    public class InheritanceTest
    {
        public virtual string start()
        {
            return "Vehicle started";
        }
    }

    public class Bike:InheritanceTest
    {
        public override string start()
        {
            return "Kick start";
        }
    }
}
