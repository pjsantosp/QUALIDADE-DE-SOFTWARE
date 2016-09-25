using System;

namespace Atendimento.Hospitalar.Models
{
    public class Paciente : Pessoa
    {
        public int PacienteId { get; set; }
        public DateTime dtNascimento { get; set; }
        public virtual TipoConveniado TipoConveniado { get; set; }
    }
}
