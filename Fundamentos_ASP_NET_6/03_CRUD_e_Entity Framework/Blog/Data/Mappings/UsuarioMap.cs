﻿using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Tabela
            builder.ToTable("Usuario");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Biografia);
            builder.Property(x => x.Email);
            builder.Property(x => x.Imagem);
            builder.Property(x => x.Senha);

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnName("Slug")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            // Índices
            builder
                .HasIndex(x => x.Slug, "IX_Usuario_Slug")
                .IsUnique();

            // Relacionamentos
            builder
                .HasMany(x => x.Funcoes)
                .WithMany(x => x.Usuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioFuncao",
                    role => role
                        .HasOne<Funcao>()
                        .WithMany()
                        .HasForeignKey("FuncaoId")
                        .HasConstraintName("FK_UsuarioFuncao_FuncaoId")
                        .OnDelete(DeleteBehavior.Cascade),
                    usuario => usuario
                        .HasOne<Usuario>()
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_UsuarioFuncao_UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}