using Atendimento.Hospitalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Atendimento.Hospitalar.BO
{
    public class UsuarioAtendenteBO : CRUD_Entity<UsuarioAtendente, int>
    {
        public UsuarioAtendenteBO(DbContext contexto) : base(contexto)
        {
        }
        public override void Inserir(UsuarioAtendente usuarioAtendente)
        {
            base.Inserir(usuarioAtendente);
        }
        public override void Alterar(UsuarioAtendente entidade)
        {
            base.Alterar(entidade);
        }
        public override void Excluir(int id)
        {
            base.Excluir(id);
        }
        public override IEnumerable<UsuarioAtendente> Selecionar()
        {
            return base.Selecionar();
        }
        public override UsuarioAtendente SelecionarPorId(int id)
        {
            return base.SelecionarPorId(id);
        }
       public UsuarioAtendente VerificaUsuario (string login, string senha)
        {
            var usuario = Selecionar().FirstOrDefault(u => u.Login == login && u.Senha == senha);
            return usuario;
        }
   

    }
}