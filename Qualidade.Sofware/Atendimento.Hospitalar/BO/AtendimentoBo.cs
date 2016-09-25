using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Paleativa = Atendimento.Hospitalar.Models; 

namespace Atendimento.Hospitalar.BO
{
    public class AtendimentoBO : CRUD_Entity<Paleativa.Atendimento, int>
    {
        public AtendimentoBO(DbContext contexto) : base(contexto)
        {
        }
        public override void Inserir(Paleativa.Atendimento entidade)
        {
            base.Inserir(entidade);
        }
        public override void Alterar(Paleativa.Atendimento entidade)
        {
            base.Alterar(entidade);
        }
        public override void Excluir(int id)
        {
            base.Excluir(id);
        }
        public override IEnumerable<Paleativa.Atendimento> Selecionar()
        {
            return base.Selecionar();
        }
        public override Paleativa.Atendimento SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
    }
}