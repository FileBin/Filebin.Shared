using System.ComponentModel.DataAnnotations.Schema;
using Filebin.Shared.Domain.Abstractions;

namespace Filebin.Shared.LayeredWebApp.DomainLayer;
[Table("test_entities")]
public class TestEntity : IEntity {
    [Column("id")]
    public Guid Id { get; set; }
    
    [Column("name")]
    public required string Name { get; set; }
}