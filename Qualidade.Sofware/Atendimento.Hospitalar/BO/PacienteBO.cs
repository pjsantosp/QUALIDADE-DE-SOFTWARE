using Atendimento.Hospitalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Atendimento.Hospitalar.BO
{
    public class PacienteBO : CRUD_Entity<Paciente, int>
    {
        public PacienteBO(DbContext contexto) : base(contexto)
        {
        }
        public override void Inserir(Paciente entidade)
        {
            base.Inserir(entidade);
        }
        public override void Alterar(Paciente entidade)
        {
            base.Alterar(entidade);
        }
        public override void Excluir(int id)
        {
            base.Excluir(id);
        }
        public override Paciente SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
        public override IEnumerable<Paciente> Selecionar()
        {
            return base.Selecionar();
        }
    }
}