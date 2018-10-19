using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar");

            Property(e => e.CEP)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(8)
                .IsFixedLength();

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("varchar");

            HasRequired(e => e.Cliente).WithMany(c => c.Enderecos).HasForeignKey(e => e.CLienteId);

            ToTable("Endereco");
        }
    }
}
