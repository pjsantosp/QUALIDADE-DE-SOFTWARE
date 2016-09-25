using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento.Hospitalar.BO
{
   public interface ICRUD<Entidade, Chave>
        where Entidade : class
    {
        void Inserir(Entidade entidade);
        void Alterar(Entidade entidade);
        void Excluir(Chave id);
        IEnumerable<Entidade> Selecionar();
        Entidade SelecionarPorId(Chave id);
    }
}
