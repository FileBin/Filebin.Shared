using Microsoft.AspNetCore.Routing;

namespace Filebin.Shared.Misc.Services.Abstraction;

public interface IEndpoint {
    void MapEndpoint(IEndpointRouteBuilder app);
}