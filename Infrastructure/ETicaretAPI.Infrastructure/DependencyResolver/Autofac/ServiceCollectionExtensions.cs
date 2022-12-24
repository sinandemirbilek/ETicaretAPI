using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Infrastructure.DependencyResolver.Autofac
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services,
            ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(services);
            }

            return ServiceTool.Create(services);
        }
    }

}
