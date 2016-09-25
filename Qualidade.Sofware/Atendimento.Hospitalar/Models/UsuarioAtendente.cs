namespace Atendimento.Hospitalar.Models
{
    public class UsuarioAtendente : Pessoa
    {

        public int AtendenteId { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }

    }
}
