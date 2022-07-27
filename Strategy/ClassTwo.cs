using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public class ClassTwo : ClassAbstract
    {
        public ClassTwo() {}
        public override bool ReturnTrueOrFalse() => true;
    }
}