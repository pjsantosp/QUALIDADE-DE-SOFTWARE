using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atendimento.Hospitalar.Models
{
    public class Servico
    {
      
        public int ServicoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Atendimento>ListaDeAtendimento { get; set; }
    }
}