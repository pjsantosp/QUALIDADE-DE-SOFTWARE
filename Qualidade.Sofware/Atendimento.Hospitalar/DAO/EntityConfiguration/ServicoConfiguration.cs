using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atendimento.Hospitalar.Models.EntityConfiguration
{
    public class ServicoConfiguration: EntityTypeConfiguration<Servico>
    {
        public ServicoConfiguration()
        {
            ToTable("Servico");
            Property(e => e.ServicoId);
            Property(e => e.Descricao).HasMaxLength(200);
        }
    }
}