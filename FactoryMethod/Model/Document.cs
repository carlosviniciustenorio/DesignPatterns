using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages { get { return _pages;} }

        public Document()
        {
            this.CreatePages();
        }

        // Factory Method
        public abstract void CreatePages();
    }
}