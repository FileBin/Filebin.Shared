using Filebin.Shared.Misc.Repository;
using Filebin.Shared.LayeredWebApp.DomainLayer;
using Filebin.Shared.Domain.Abstractions;

namespace Filebin.Shared.LayeredWebApp.InfrastructureLayer.Repository;

internal class TestRepository(IEntityAccessor accessor, IEntityObtainer obtainer) : CrudRepositoryBase<TestEntity>(accessor, obtainer) {
}