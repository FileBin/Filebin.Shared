using Microsoft.Extensions.DependencyInjection;

namespace Filebin.Shared.LayeredWebApp.ApplicationLayer;

public static class ConfigureServices {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddScoped<TestCrudService>();
        return services;
    }
}
