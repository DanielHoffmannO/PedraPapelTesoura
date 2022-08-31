using PedraPapelTesoura.Application.ApplicationServices;
using PedraPapelTesoura.Application.Interface;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(IServiceCollection Services)
        => Services.AddScoped<IPedraPapelTesouraApplication, PedraPapelTesouraApplication>();
    }
}