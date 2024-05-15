using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class PostMap : IEntityTypeConfiguration<Post>
{
    // Método para mapear a entidade Post
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        // Tabela
        builder.ToTable("Post");

        // Chave Primária
        builder.HasKey(x => x.Id);

        // Autoincremento
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        // Propriedades
        builder
            .Property(x => x.DataModificacao)
            .IsRequired()
            .HasColumnName("DataModificacao")
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60)
            .HasDefaultValueSql("GETDATE()");

        // Índice (Slug único) 
        builder
            .HasIndex(x => x.Slug, "IX_Post_Slug")
            .IsUnique();

        // Relacionamento (Um Usuário tem muitos Posts)
        builder
            .HasOne(x => x.Usuario)
            .WithMany(x => x.Posts)
            .HasConstraintName("FK_Post_Usuario")
            .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento (Uma Categoria tem muitos Posts)
        builder
            .HasOne(x => x.Categoria)
            .WithMany(x => x.Posts)
            .HasConstraintName("FK_Post_Categoria")
            .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento (Muitos Posts tem muitas Tags)
        builder
            .HasMany(x => x.Tags)
            .WithMany(x => x.Posts)
            .UsingEntity<Dictionary<string, object>>(
                "PostTag",
                post => post
                    .HasOne<Tag>()
                    .WithMany()
                    .HasForeignKey("PostId")
                    .HasConstraintName("FK_PostTag_PostId")
                    .OnDelete(DeleteBehavior.Cascade),
                tag => tag
                    .HasOne<Post>()
                    .WithMany()
                    .HasForeignKey("TagId")
                    .HasConstraintName("FK_PostTag_TagId")
                    .OnDelete(DeleteBehavior.Cascade));
    }
}