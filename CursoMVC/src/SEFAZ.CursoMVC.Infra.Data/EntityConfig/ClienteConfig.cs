using SEFAZ.CursoMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEFAZ.CursoMVC.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteID);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");
            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            Property(c => c.DataNascimento)
                .IsRequired();

            ToTable("Clientes");
        }
    }
}
