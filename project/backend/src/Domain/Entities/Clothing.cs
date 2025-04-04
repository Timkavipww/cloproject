using Domain.Common;

namespace Domain.Entities;

public class Clothing : BaseEntity, IAudiable
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public Brand? Brand { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
}