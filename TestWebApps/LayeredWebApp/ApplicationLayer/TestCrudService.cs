using Filebin.Shared.Domain.Abstractions;
using Filebin.Shared.LayeredWebApp.ApplicationLayer.Models;
using Filebin.Shared.LayeredWebApp.DomainLayer;
using Filebin.Shared.Misc.Services;

namespace Filebin.Shared.LayeredWebApp.ApplicationLayer;

public class TestCrudService(IEntityRepository<TestEntity> repository, IUnitOfWork unitOfWork) 
: CrudServiceBase<TestEntity, TestEntityResponse, CreateRequest, UpdateRequest>(repository, unitOfWork) {}