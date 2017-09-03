using Nancy.Bootstrapper;

namespace Nancy.AspNetCore.Http.Accessors
{
    public interface INancyAccessors
    {
        TContainer GetContainer<TContainer>();
        IPipelines GetPipelines();
    }
}