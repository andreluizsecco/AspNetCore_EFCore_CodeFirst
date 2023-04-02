using AspNetCore_EFCore_CodeFirst.Mappings;
using AspNetCore_EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_EFCore_CodeFirst.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
