using Microsoft.EntityFrameworkCore;
using Models;

namespace Database;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
}