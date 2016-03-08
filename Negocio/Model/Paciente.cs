using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Model
{
    public class Paciente
    {
        private int pacienteId;
        public int PacienteId
        {
            get { return pacienteId; }
            set { pacienteId = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private DateTime dtNascimento;
        public DateTime DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        private string tipoConveniado;
        public string TipoConveniado
        {
            get { return tipoConveniado; }
            set { tipoConveniado = value; }
        }
        private string planoSaude;
        public string PlanoSaude
        {
            get { return planoSaude; }
            set { planoSaude = value; }
        }
    }
}
