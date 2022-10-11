using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public class ButtonFactory
    {
        public static Button CreatButton() => new Button {Type = "Red Button".Dump()};
    }
}