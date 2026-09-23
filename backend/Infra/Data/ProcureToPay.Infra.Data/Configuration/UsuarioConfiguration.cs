using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcureToPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcureToPay.Infra.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.UsuarioId) 
                .HasName("pk_usuario_id");

            builder.Property(u => u.UsuarioId)
                .HasColumnName("usuario_id")
                .ValueGeneratedOnAdd();

            builder.Property(u => u.UsuarioNome)
                .HasColumnName("usuario_nome")
                .HasMaxLength(200);

            builder.Property(u => u.UsuarioEmail)
                .HasColumnName("usuario_email")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(u => u.UsuarioCPF)
                .HasColumnName("usuario_cpf")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(u => u.UsuarioSenhaHash)
                .HasColumnName("usuario_senha_hash")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(u => u.UsuarioAtivo)
                .HasColumnName("usuario_ativo")
                .IsRequired();

            builder.Property(u => u.UsuarioDataCriao)
                .HasColumnName("usuario_data_criacao")
                .IsRequired();
        }
    }
}
