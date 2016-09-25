using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atendimento.Hospitalar.Models
{
    public class PacienteConfiguration: EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            ToTable("Paciente");
            Property(p => p.PacienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nome).HasMaxLength(200).IsRequired();
            Property(p => p.dtNascimento).HasColumnType("DateTime");

        }
    }
}