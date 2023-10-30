

using Microsoft.EntityFrameworkCore;
using ShopTestsNetCore.Models;

namespace ShopTestsNetCore.Context
{
    public class AppDbContext : DbContext
    {

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseInMemoryDatabase(databaseName: "ShopTestsDb");
        // }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Cliente> Clientes => Set<Cliente>();

        

    }
}