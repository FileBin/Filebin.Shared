using Filebin.Shared.LayeredWebApp.PresentationLayer.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace Filebin.Shared.LayeredWebApp.PresentationLayer;

public static class ConfigureServices {
    public static IServiceCollection AddPresentation(this IServiceCollection services) {
        services.AddControllers().AddApplicationPart(typeof(TestController).Assembly);
        return services;
    }
}
