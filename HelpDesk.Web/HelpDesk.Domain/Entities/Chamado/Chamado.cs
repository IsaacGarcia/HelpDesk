using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.ComponenteChamado
{
    public class Chamado
    {
        public virtual string Descricao { get; set; }
        public virtual DateTime DataDeSolicitacao { get; set; }
    }
}