using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Infrastructure.DependencyResolver.Autofac
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }

}
