using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public class ClassOne : ClassAbstract
    {
        public ClassOne() {}
        public override bool ReturnTrueOrFalse() => true;
    }
}