using Microsoft.EntityFrameworkCore;
using Filebin.Shared.Misc.Repository;
using Filebin.Shared.LayeredWebApp.InfrastructureLayer.Database;
using Filebin.Shared.LayeredWebApp.DomainLayer;

namespace Filebin.Shared.LayeredWebApp.InfrastructureLayer.Repository;

internal class TestRepository(TestDbContext dbContext) : CrudRepositoryBase<TestEntity> {
    protected override DbSet<TestEntity> GetDbSet() => dbContext.Entities;
}