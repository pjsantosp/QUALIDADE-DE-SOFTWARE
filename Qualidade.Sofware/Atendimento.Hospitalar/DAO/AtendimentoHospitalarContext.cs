using Atendimento.Hospitalar.Models.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Atendimento.Hospitalar.Models
{
    public class AtendimentoHospitalarContext:DbContext
    {
        public AtendimentoHospitalarContext()
            :base("dbAtendimentoHospitalar")
        {
        }
        public virtual IDbSet<Paciente> Paciente { get; set; }
        public virtual IDbSet<UsuarioAtendente> UsuarioAtendente { get; set; }
        public virtual IDbSet<Servico> Servico { get; set; }
        public virtual IDbSet<Atendimento> Atendimento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());

            modelBuilder.Configurations.Add(new UsuarioAtendenteConfiguration());
            modelBuilder.Configurations.Add(new AtendimentoConfiguration());
            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new ServicoConfiguration());

        }

    }
}