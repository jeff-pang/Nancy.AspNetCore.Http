using Microsoft.AspNetCore.Http;

namespace Nancy.AspNetCore.Http.Accessors
{
    internal class NancyHttpContextAccessor : IHttpContextAccessor
    {
        public HttpContext HttpContext { get; set; }
    }
}
