using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atendimento.Hospitalar.Models
{
    public class UsuarioAtendenteConfiguration:EntityTypeConfiguration<UsuarioAtendente>
    {
        public UsuarioAtendenteConfiguration()
        {
            ToTable("Atendente");
            HasKey(a => a.AtendenteId);
            Property(a => a.Nome).HasMaxLength(200).IsRequired();
            Property(a => a.Login).HasMaxLength(50).IsRequired();
            Property(a => a.Senha).HasMaxLength(50).IsRequired();
        }
    }
}