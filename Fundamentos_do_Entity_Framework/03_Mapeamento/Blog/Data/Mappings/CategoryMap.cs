using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Tabela
            builder.ToTable("Category");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(); // Primary Key Identity (1, 1)

            // Propriedades
            builder.Property(x => x.Name) // Define qual propriedade trabalhar
                .IsRequired() // Constraint - Not Null
                .HasColumnName("Name") // Nome da Coluna
                .HasColumnType("NVARCHAR") // Tipo da Coluna
                .HasMaxLength(80); // Máximo de Caracteres

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);
        }
    }
}