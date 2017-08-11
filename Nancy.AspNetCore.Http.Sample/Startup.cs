﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;
using Microsoft.AspNetCore.Builder;

namespace Nancy.AspNetCore.Session.Sample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                //Add in-proc memory Session Cache Middleware, 
                //this can be any other middleware such as Redis Cache
                .AddDistributedMemoryCache()
                //Wire up AspNetCore with Nancy
                .AddNancyAspnetCoreSession()
                //Add AspNetCore Session
                .AddSession();
        }

        public void Configure(IApplicationBuilder app)
        {
            app
            .UseSession()
            .UseOwin(x =>
            {
                x.UseNancy();
            })
            .UseNancyAspnetCoreSession();
        }
    }
}