using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Atendimento.Hospitalar.BO
{
    public class CRUD_Entity<Entidade, Chave> : ICRUD<Entidade, Chave>
        where Entidade : class
    {
        protected DbContext _contexto;

        public CRUD_Entity(DbContext contexto)
        {
            _contexto = contexto;
        }
        public virtual void Alterar(Entidade entidade)
        {
            try
            {
                _contexto.Set<Entidade>().Attach(entidade);
                _contexto.Entry(entidade).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro em CRUD_Entity Alterar" + ex.Message);
            }
        }

        public virtual void Excluir(Chave id)
        {
            try
            {
                Entidade entidade = SelecionarPorId(id);
                _contexto.Set<Entidade>().Attach(entidade);
                _contexto.Entry(entidade).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro no CRUD_Entity excluir" + ex.Message);
            }
        }

        public virtual void Inserir(Entidade entidade)
        {
            try
            {
                _contexto.Set<Entidade>().Add(entidade);
                _contexto.SaveChanges();
            }
            catch (Exception ex )
            {

                throw new Exception("Erro no Inserir CRUD_Entity" + ex.Message);
            }
        }

        public virtual IEnumerable<Entidade> Selecionar()
        {
            try
            {
                return _contexto.Set<Entidade>().AsEnumerable();
            }
            catch (Exception)
            {
                throw new Exception("Erro Durante a Seleção CRUD_Entity");
            }
        }

        public virtual Entidade SelecionarPorId(Chave id)
        {
            try
            {
                return _contexto.Set<Entidade>().Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no Selecionar por ID em CRUD_Entity"+ ex.Message);
            }
        }
    }
}