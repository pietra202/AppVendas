using AppVendas.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace AppVendas.Data
{
    public class ApplicationDdContext : DbContext
    {
        public ApplicationDdContext(DbContextOptions<ApplicationDdContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemDaVenda> ItemDaVenda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Produtos>().ToTable("Produtos");
            modelBuilder.Entity<Venda>().ToTable("Venda");
            modelBuilder.Entity<ItemDaVenda>().ToTable("ItemDaVenda");
        }
    }
}
