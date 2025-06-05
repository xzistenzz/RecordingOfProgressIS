using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace RecordingOfProgressIS.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        
        services.AddMediatR(cfg=> cfg.RegisterServicesFromAssembly(assembly));
        services.AddAutoMapper(assembly);
        
        return services;
    }
}