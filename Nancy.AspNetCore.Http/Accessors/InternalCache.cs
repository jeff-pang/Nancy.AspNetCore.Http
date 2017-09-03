using Microsoft.AspNetCore.Http;

namespace Nancy.AspNetCore.Http.Accessors
{
    public struct InternalHttpContextCache
    {
        private static IHttpContextAccessor httpContextAccessor  = new NancyHttpContextAccessor();
        internal IHttpContextAccessor HttpContextAccessor { get { return httpContextAccessor; } }        
    }
}
