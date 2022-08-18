using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IContentRepository
    {
        List<Content> GetContent();
    }
}