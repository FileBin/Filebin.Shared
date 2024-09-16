using Filebin.Shared.LayeredWebApp.InfrastructureLayer.Database;
using Filebin.Shared.Misc;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.LayeredWebApp.InfrastructureLayer.Repository;

internal class UnitOfWork(TestDbContext dbContext) : UnitOfWorkBase {
    public override DbContext GetDbContext() => dbContext;
}
