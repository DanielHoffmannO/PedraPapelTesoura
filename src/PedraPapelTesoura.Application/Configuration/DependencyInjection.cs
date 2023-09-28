using Microsoft.Extensions.DependencyInjection;
using PedraPapelTesoura.Domain.IApplication;

namespace PedraPapelTesoura.Application.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApplication(this IServiceCollection services)
                => services.AddScoped<IPedraPapelTesouraApplication, PedraPapelTesouraApplication>();

}