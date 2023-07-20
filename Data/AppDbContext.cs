using Microsoft.EntityFrameworkCore;
using Bogus;
using generate_data_bogus.Models;

namespace generate_data_bogus.Data;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Produto> Produtos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseInMemoryDatabase("generate-data-bogus");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Cliente>()
            .HasData(Cliente.Fake().GenerateBetween(2, 5));

        modelBuilder
            .Entity<Produto>()
            .HasData(Produto.Fake().GenerateBetween(2, 5));
    }    
}
