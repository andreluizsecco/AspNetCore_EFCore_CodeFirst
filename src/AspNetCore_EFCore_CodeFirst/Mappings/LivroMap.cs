using AspNetCore_EFCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCore_EFCore_CodeFirst.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(p => p.ID)
                .ValueGeneratedNever();

            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)");

            builder.Property(p => p.DataEntrada)
                .HasColumnType("datetime");

            builder.HasIndex(p => p.Titulo)
                .HasDatabaseName("IX_Livro_Titulo");

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Livros)
                .HasForeignKey(p => p.CategoriaID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Livro(1, 1, "Domain-Driven Design: Tackling Complexity in the Heart of Software", "Eric Evans", 26, 59.90m),
                new Livro(2, 1, "Agile Principles, Patterns, and Practices in C#", "Robert C. Martin", 13, 45.90m),
                new Livro(3, 1, "Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 10, 33.90m),
                new Livro(4, 1, "Implementing Domain-Driven Design", "Vaughn Vernon", 22, 59.90m),
                new Livro(5, 1, "Patterns, Principles, and Practices of Domain-Driven Design", "Scott Millet", 15, 42.90m),
                new Livro(6, 1, "Refactoring: Improving the Design of Existing Code", "Martin Fowler", 5, 31.90m)
            );
        }
    }
}
