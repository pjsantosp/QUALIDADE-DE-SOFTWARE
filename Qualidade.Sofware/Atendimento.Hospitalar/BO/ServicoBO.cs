using Atendimento.Hospitalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Atendimento.Hospitalar.BO
{
    public class ServicoBO : CRUD_Entity<Servico, int>
    {
        public ServicoBO(DbContext contexto) : base(contexto)
        {
        }

        public override void Inserir(Servico entidade)
        {
            base.Inserir(entidade);
        }
        public override void Alterar(Servico entidade)
        {
            base.Alterar(entidade);
        }
        public override void Excluir(int id)
        {
            base.Excluir(id);
        }
        public override IEnumerable<Servico> Selecionar()
        {
            return base.Selecionar();
        }
        public override Servico SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
    }
}