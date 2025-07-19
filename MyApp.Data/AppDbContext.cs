using Microsoft.EntityFrameworkCore;
using MyApp.Data.Entities;

namespace MyApp.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Member> Members { get; set; }
}