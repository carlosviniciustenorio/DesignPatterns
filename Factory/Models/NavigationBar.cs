using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory.Models
{
    public class NavigationBar
    {
        public NavigationBar() => ButtonFactory.CreatButton();
    }
}