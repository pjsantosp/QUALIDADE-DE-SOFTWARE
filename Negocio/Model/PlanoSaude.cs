using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Model
{
    public class PlanoSaude
    {
        private int planoDeSaudeId;
        public int PlanoSaudeId
        {
            get { return planoDeSaudeId; }
            set { planoDeSaudeId = value; }
        }
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
