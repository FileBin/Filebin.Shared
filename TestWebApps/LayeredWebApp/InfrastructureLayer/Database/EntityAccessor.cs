using Filebin.Shared.Misc.Repository.Accessors;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.LayeredWebApp.InfrastructureLayer.Database;

internal class EntityAccessor(TestDbContext context) : DefaultEntityAccessor {
    protected override DbContext GetDbContext() => context;
}