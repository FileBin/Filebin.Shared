using System.Security.Claims;
using Filebin.Shared.Exceptions.Models;
using Filebin.Shared.Misc;
using Microsoft.AspNetCore.Authorization;

namespace Filebin.Shared.SimpleWebApp;

public class Program {
    static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddUtils()
            .AddIdentityServer(builder.Configuration, builder.Environment);

        var app = builder.Build();

        app.UseUtils();

        app.MapGet("/userinfo", [Authorize] (ClaimsPrincipal user) => user.Claims.Select(x => new { x.Type, x.Value }));
        app.MapGet("/test404", () => { throw new NotFoundException("Something not found!"); });

        app.UseIdentityServer();
        app.Run();
    }
}