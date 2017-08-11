using Microsoft.AspNetCore.Http;
using Nancy.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nancy.AspNetCore.Http.Accessors
{
    public interface INancyAccessors
    {
        TContainer GetContainer<TContainer>();
        IPipelines GetPipelines();
    }
}