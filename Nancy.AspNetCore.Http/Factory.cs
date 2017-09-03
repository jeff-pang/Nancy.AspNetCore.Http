using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Nancy.AspNetCore.Http.Accessors;
using Nancy.Bootstrapper;
using System;
using System.Reflection;

namespace Nancy.AspNetCore.Http
{
    public static class Factory
    {
        private static InternalHttpContextCache httpCtxCache;
        private static bool isContextInitialised = false;
        public static IHttpContextAccessor Create(IServiceCollection service)
        {
            if (!isContextInitialised)
            {
                service.AddSingleton(httpCtxCache.HttpContextAccessor);
                isContextInitialised = true;
            }

            return httpCtxCache.HttpContextAccessor;
        }

        public static INancyAccessors Create(IApplicationBuilder app)
        {
            Type type = NancyBootstrapperLocator.Bootstrapper.GetType();

            //reflection to get protected property ApplicationPipelines
            PropertyInfo pipelinesProp = type.GetProperty("ApplicationPipelines", BindingFlags.NonPublic | BindingFlags.Instance);
            var pipelines = pipelinesProp.GetValue(NancyBootstrapperLocator.Bootstrapper) as IPipelines;

            //reflection to get protected property ApplicationContainer
            PropertyInfo containerProp = type.GetProperty("ApplicationContainer", BindingFlags.NonPublic | BindingFlags.Instance);
            object container = containerProp.GetValue(NancyBootstrapperLocator.Bootstrapper);
            
            return new NancyAccessors(container, pipelines);
        }
    }
}