using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyClass
    {
        ClassAbstract classAbstract;
        public StrategyClass(ClassAbstract classAbstract)
        {
            this.classAbstract = classAbstract;
        }

        public bool ContextInterface() => classAbstract.ReturnTrueOrFalse();
    }
}