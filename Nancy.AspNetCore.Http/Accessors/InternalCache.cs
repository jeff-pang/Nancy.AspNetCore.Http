using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nancy.AspNetCore.Http.Accessors
{
    public struct InternalHttpContextCache
    {
        private static IHttpContextAccessor httpContextAccessor  = new NancyHttpContextAccessor();
        internal IHttpContextAccessor HttpContextAccessor { get { return httpContextAccessor; } }        
    }
}
