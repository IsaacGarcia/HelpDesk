using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Domain.ComponenteCliente;

namespace HelpDesk.Domain.Entities.ComponenteProduto
{
    public class Produto
    {
        public virtual SLA SLA { get; set; }
    }
}
