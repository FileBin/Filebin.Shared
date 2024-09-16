using Filebin.Shared.Domain.Abstractions;

namespace Filebin.Shared.Misc.Auth;

internal class ClaimUserDescriptor : IUserDescriptor {

    public string? Id { get; init; }
    public string? Name { get; init; }
    internal required bool IsAdminBool { get; init; }
    public bool IsAdmin() => IsAdminBool;
    public bool IsAuthenticated() => Id is not null;

}
