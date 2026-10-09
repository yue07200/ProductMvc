using Microsoft.EntityFrameworkCore;

public class ProductMvcContext(DbContextOptions<ProductMvcContext> options) : DbContext(options)
{
    public DbSet<ProductMvc.Models.Product> Product { get; set; } = default!;
}
