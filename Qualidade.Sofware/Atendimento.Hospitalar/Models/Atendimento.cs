using System;
using System.Collections.Generic;

namespace Atendimento.Hospitalar.Models
{
    public class Atendimento
    {
        public Atendimento()
        {
            ListaDeServico = new List<Servico>();
        }
        public int AtendimentoId { get; set; }
        public DateTime Data { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual ICollection<Servico> ListaDeServico { get; set; }

    }
}
