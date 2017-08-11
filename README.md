# Nancy.AspNetCore.Http
Integration points for AspNetCore Http features into Nancy

Provides support for extensions of AspNetCore Http features and Nancy. 

## Usage

Use `Factory.Create(IServiceCollection service)` method to register and get access to HttpContextAccessor. Example usage:

```C#
public static IServiceCollection AddNancyAspnetCoreSession(this IServiceCollection service)
{
	httpCtxAcs = Factory.Create(service);
	return service;
}
```

Use `Factory.Create(IApplicationBuilder builder)` to gain access to Nancy's pipeline and container. Example usage:

```C#
public static IApplicationBuilder UseNancyAspnetCoreSession(this IApplicationBuilder builder)
{
	//Get INancyAccessors to gain access to Nancy Pipeline and oC Container
	INancyAccessors nancyAccessors = Factory.Create(builder);
	IPipelines piplines = nancyAccessors.GetPipelines();
	TinyIoCContainer container = nancyAccessors.GetContainer<TinyIoCContainer>();
	
	return builder;
}
```