using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrasturcture.Persistence;

public class ClothingDbContext : DbContext
{
    public ClothingDbContext(DbContextOptions<ClothingDbContext> options) : base(options)
    {

    }
    public DbSet<Clothing> clothings { get; set; }
    
}
